﻿using MOVEROAD.InfoFile;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MOVEROAD
{
    public class DBConnetion
    {
        private string dbip = "211.229.51.172";
        private string dbname = "project";
        private string dbpass = "road";
        private string dbid = "move";
        private static DBConnetion instance_ = new DBConnetion();

        public static DBConnetion getInstance()
        {
            return instance_;
        }

        public MySqlConnection getDBConnetion()
        {
            try
            {
                string con = "Server=" + dbip + ";Database=" + dbname + ";Uid=" + dbid + ";Pwd=" + dbpass + ";Charset=utf8";
                MySqlConnection conn = new MySqlConnection(con);
                conn.Open();
                conn.Close();
                return conn;
            }
            catch
            {
                MessageBox.Show("DB서버 연결오류");
                return null;
            }
        }

        public object Select(string sql, int token)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            object thing = new object();
            switch (token)
            {
                case 0:
                    if (rdr.Read())
                    {
                        UserInfo me = new UserInfo((int)rdr["index"], (string)rdr["name"], (int)rdr["age"], (int)rdr["depart"], (int)rdr["grade"], (string)rdr["address"], (int)rdr["gender"], (string)rdr["id"]);
                        thing = me;
                        break;
                    }
                    thing = null;
                    break;
                case 1:
                    rdr.Read();
                    break;
                case 2:
                    List<DepartmentInfo> departments = new List<DepartmentInfo>();
                    while (rdr.Read())
                    {
                        DepartmentInfo department = new DepartmentInfo((int)rdr["id"], (string)rdr["name"], (int)rdr["manager"]);
                        departments.Add(department);
                    }
                    thing = departments;
                    break;
                case 3:
                    rdr.Read();
                    String str = ((string)rdr["name"]);
                    thing = str;
                    break;
                case 4:
                    DataTable taskClassInfo = new DataTable();
                    //열 생성
                    taskClassInfo.Columns.Add("ID", typeof(int));   //table내에서 부여한 고유 ID
                    taskClassInfo.Columns.Add("Name", typeof(string));    //이름
                    taskClassInfo.Columns.Add("ParentID", typeof(int));       //상위 class의 ID
                    taskClassInfo.Columns.Add("Level", typeof(int));          //대분류 = 1 중분류 = 2 소분류 = 3

                    while (rdr.Read())
                    {
                        taskClassInfo.Rows.Add((int)rdr["id"], (string)rdr["name"], (int)rdr["parent_id"], (int)rdr["level"]);
                    }
                    thing = taskClassInfo;
                    break;
            }
            rdr.Close();
            conn.Close();
            return thing;
        }

        public List<string> revise_userlist(string sql)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(string.Format("{0}", rdr["name"]));
                list.Add(string.Format("{0}", rdr["manager"]));
                list.Add(string.Format("{0}", rdr["description"]));
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public List<string> search_userlist(string sql)
        {
            List<string> list = new List<string>();
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                list.Add(string.Format("{0}", rdr["name"]));
                list.Add(string.Format("{0}", rdr["index"]));
            }
            rdr.Close();
            conn.Close();
            return list;
        }

        public DataTable getDBTable(string sql) // 사원정보 데이터 그리드뷰에 넣는거
        {
            using (MySqlConnection conn = getDBConnetion())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                DataTable table = new DataTable();

                table.Load(rdr);
                return table;
            }
        }
        public void Update(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public void Insert(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(string sql)
        {
            MySqlConnection conn = getDBConnetion();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

    }
}
