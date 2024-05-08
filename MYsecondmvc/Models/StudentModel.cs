using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MYsecondmvc.Data;
namespace MYsecondmvc.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email_id { get; set; }
        public string DOB { get; set; }
        public string Contact_No { get; set; }
        public string Address { get; set; }

        public int Srno { get; set; }
        public string Savereg(StudentModel model)
        {
            string msg = "Save";

            MYsecondmvcEntities Db = new MYsecondmvcEntities();
            {
                var regData = new tblStudent()
                {

                    Name = model.Name,
                    Email_id = model.Email_id,
                    DOB = model.DOB,
                    Contact_No = model.Contact_No,
                    Address = model.Address,
                };
                Db.tblStudents.Add(regData);
                Db.SaveChanges();
                return msg;
            }

        }
        public List<StudentModel> GetMYsecondmvcList()
        {
            MYsecondmvcEntities Db = new MYsecondmvcEntities();
            List<StudentModel> lststudent = new List<StudentModel>();
            var AddStudentList = Db.tblStudents.ToList();
            int Srno = 1;

            if (AddStudentList != null)
            {
                foreach (var Student in AddStudentList)
                {
                    lststudent.Add(new StudentModel()
                    {
                        Srno = Srno,
                        Id = Student.Id,
                        Name = Student.Name,
                        Email_id = Student.Email_id,
                        DOB = Student.DOB,
                        Contact_No = Student.Contact_No,
                        Address = Student.Address,
                        
                    });
                    Srno++;
                }
            }
            return lststudent;

        }
    }
}
