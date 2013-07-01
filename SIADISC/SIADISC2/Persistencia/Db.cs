using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace SIADISC2.Persistencia
{
    public class Db
    {

        protected MySqlConnection connection;

        public Db(string connectionString)
        {

            this.connection = new MySqlConnection(connectionString);

        }

        public bool byPk(object pkValue, object model)
        {            
            Type ModelClass = model.GetType();
            Dictionary<string, object> data = this.byPk("id", pkValue, ModelClass.BaseType.Name.ToLower());
            //object model = Activator.CreateInstance(ModelClass);
            if (data == null) return false;
            foreach (KeyValuePair<string, object> entry in data) 
            {
                FieldInfo field = ModelClass.GetField(entry.Key);
                field.SetValue(model, entry.Value);
            }
            return true;
        }

        public Dictionary<string, object> byPk(object pkValue, string table) {            
            return this.byPk("id", pkValue, table);
        }

        public Dictionary<string, object> byPk(string pkName, object pkValue, string table)
        {
            this.connection.Open();
            MySqlCommand cmd = this.prepareQuery("SELECT * FROM " + this.scape(table) + " WHERE " + this.scape(pkName) + "={0} LIMIT 1", pkValue);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (!reader.Read())
                return null; // TODO Exception
            Dictionary<string, object> data = new Dictionary<string, object>();
            for (int i = 0; i < reader.FieldCount; i++)
            {
                data.Add(reader.GetName(i), reader.GetValue(i));
            }
            this.connection.Close();
            return data;
        }

        public MySqlCommand prepareQuery(string sql, params object[] data)
        {
            MySqlCommand cmd = this.connection.CreateCommand();
            for (int i = 0; i < data.Length; i++)
            {
                string param = "{" + i + "}";
                string paramName = "@db_" + i;
                sql = sql.Replace(param, paramName);
                cmd.Parameters.AddWithValue(paramName, data[i]);
            }
            cmd.CommandText = sql;
            return cmd;
        }

        public void insertInto(string table, Dictionary<string, object> data)
        {
            MySqlTransaction transaccion = this.connection.BeginTransaction();
            this.insertInto(table, data, transaccion);
            transaccion.Commit();
        }

        public void insertInto(string table, Dictionary<string, object> data, MySqlTransaction transaccion)
        {
            // Create the SQL
            string sql = "INSERT INTO " + table + " (";
            sql += String.Join(", ", data.Keys);
            sql += ") VALUES (@";
            sql += String.Join(", @", data.Keys);
            sql += ")";

            MySqlCommand command = this.connection.CreateCommand();
            command.Connection = this.connection;
            command.Transaction = transaccion;
            command.CommandText = sql;
            foreach (KeyValuePair<string, object> entry in data)
            {
                command.Parameters.AddWithValue(entry.Key, entry.Value);
            }
            command.ExecuteNonQuery();
        }

        public void update(string table, Dictionary<string, object> data, long id, MySqlTransaction transaction)
        {
            this.update(table, data, new Dictionary<string, object>() { { "id", id } }, transaction);
        }

        public void update(string table, Dictionary<string, object> data, long id)
        {
            this.update(table, data, new Dictionary<string, object>() { { "id", id } });
        }

        public void update(string table, Dictionary<string, object> data, Dictionary<string, object> when)
        {
            MySqlTransaction transaction = this.connection.BeginTransaction();
            this.update(table, data, when, transaction);
            transaction.Commit();
        }

        public void update(string table, Dictionary<string, object> data, Dictionary<string, object> when, MySqlTransaction transaction)
        {
            this.update(table, data, when, "__", transaction);
        }

        public void update(string table, Dictionary<string, object> data, Dictionary<string, object> when, string whenPrefix, MySqlTransaction transaccion)
        {
            string whenSql = "";
            foreach (string key in when.Keys)
            {
                whenSql += whenPrefix + key + "=@" + whenPrefix + key + " AND ";
            }
            whenSql += "1=1";
            this.update(table, data, whenSql, when, whenPrefix, transaccion);
        }

        public void update(string table, Dictionary<string, object> data, string when, Dictionary<string, object> whenData)
        {
            MySqlTransaction transaction = this.connection.BeginTransaction();
            this.update(table, data, when, whenData, transaction);
            transaction.Commit();
        }

        public void update(string table, Dictionary<string, object> data, string when, Dictionary<string, object> whenData, MySqlTransaction transaccion)
        {
            this.update(table, data, when, whenData, "__", transaccion);
        }

        public void update(string table, Dictionary<string, object> data, string when, Dictionary<string, object> whenData, string whenPrefix, MySqlTransaction transaccion)
        {

            string sql = "UPDATE " + table + " SET ";
            foreach (string key in data.Keys)
            {
                sql += key + "=@" + key + ",";
            }
            sql = sql.TrimEnd(',');
            sql += " WHEN " + when;

            MySqlCommand command = this.connection.CreateCommand();
            command.Connection = this.connection;
            command.Transaction = transaccion;
            command.CommandText = sql;

            foreach (KeyValuePair<string, object> entry in data)
            {
                command.Parameters.AddWithValue(entry.Key, entry.Value);
            }
            foreach (KeyValuePair<string, object> entry in whenData)
            {
                command.Parameters.AddWithValue(whenPrefix + entry.Key, entry.Value);
            }
            command.ExecuteNonQuery();
        }

        public string scape(string str)
        {
            if (str == null)
                return String.Empty;
            return str.Replace("'", "''");
        }

        public MySqlConnection Connection { get { return this.connection; } }

    }
}