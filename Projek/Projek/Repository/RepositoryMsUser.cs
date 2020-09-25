using Projek.Factory;
using Projek.Model;
using Projek.Repository.Aggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projek.Repository
{
    public class RepositoryMsUser
    {
        private static TokobediaEntities db = new TokobediaEntities();
        public static void RegisData(String Nama, String Email, String Password, String Gender, Int64 ID)
        {
            db.MsUsers.Add(FactoryUser.InitUser(Nama, Email, Password, Gender, ID));
            db.SaveChanges();
        }
        public static MsUser GetUser(String email,String password)
        {
            return (from a in db.MsUsers
                    where a.UserEmail == email && a.UserPassword==password
                    select a).FirstOrDefault();
             
        }
        public static MsUser GetUserByEmail(String email)
        {
            return (from a in db.MsUsers
                    where a.UserEmail==email
                    select a).FirstOrDefault();
        }
        public static int CountData()
        {
            return (from y in db.MsUsers
                    where y.UserName != null
                    select y).Count();
        }
        public static MsUser GetUserByID(String ID)
        {
            return (from x in db.MsUsers
                    where x.UserID == ID
                    select x).FirstOrDefault();
        }
        public static List<DetailUser> FetchDataUser()
        {
            return (from x in db.MsUsers
                    join y in db.MsRoles
                    on x.RoleID equals y.RoleID
                    orderby x.UserID ascending
                    select new DetailUser
                    {
                        UserID=x.UserID,
                        UserGender=x.UserGender,
                        UserName = x.UserName,
                        UserRole = y.RoleName,
                        UserStatus = x.UserStatus
                    }).ToList();
        }
        public static void UpdateStatus(String ID, String Status)
        {
            MsUser User = GetUserByID(ID);
            User.UserStatus = Status;
            db.SaveChanges();
        }
        public static void UpdateRole(String ID, String Role)
        {
            MsUser User = GetUserByID(ID);
            User.RoleID = Role;
            db.SaveChanges();
        }
        public static void UpdateData(String ID, String Nama, String Email, String Gender)
        {
            MsUser User = GetUserByID(ID);
            User.UserName = Nama;
            User.UserEmail = Email;
            User.UserGender = Gender;
            db.SaveChanges();
        }
        public static void UpdatePassword(String ID, String Pass)
        {
            MsUser User = GetUserByID(ID);
            User.UserPassword = Pass;
            db.SaveChanges();
        }
    }
}