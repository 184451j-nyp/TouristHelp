using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using TouristHelp.Models;

namespace TouristHelp.DAL
{
    public class DirectionDAO
    {
        private SqlQuery sql = new SqlQuery();
        public List<Direction> SelectAll()
        {
            DataSet ds = sql.Query("Select * from Directions");
            return convertToObj(ds);
        } 

        public List<Direction> GetDirectionsByGrp(int group)
        {
            DataSet ds = sql.Query("Select * From Directions Where group = " + group.ToString() + " Order By group");
            return convertToObj(ds);
        }

        public List<int> GetDirGrpByUser(int user_id)
        {
            DataSet ds = sql.Query("Select Distinct group As DistinctGrps From (Select * From Directions Where user = " + user_id.ToString() + "))");
            
            List<int> list = new List<int>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = int.Parse(row["DistinctGrps"].ToString());
                list.Add(id);
            }

            return list;
        }

        public void insertUser(User user)
        {

        }

        private List<Direction> convertToObj(DataSet ds)
        {
            List<Direction> dirList = new List<Direction>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                int id = int.Parse(row["id"].ToString());
                int user = int.Parse(row["user"].ToString());
                string nodeCoord = row["nodeCoord"].ToString();
                int group = int.Parse(row["group"].ToString());
                int order = int.Parse(row["order"].ToString());
                Direction obj = new Direction(id, user, nodeCoord, group, order);
                dirList.Add(obj);
            }

            return dirList;
        }
    }
}