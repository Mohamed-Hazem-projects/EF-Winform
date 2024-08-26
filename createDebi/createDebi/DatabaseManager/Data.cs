using createDebi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace createDebi.DatabaseManager
{
    internal static class Data
    {
        public static List<Department> getDepartmentData()
        {
            return new List<Department>
            {
                new Department
                {
                    Dept_Name = "Computer Science",
                    Dept_Desc = "Focuses on computing, programming, and software development.",
                    Dept_Location = "Building A",
                    Manager_hiredate = new DateTime(2015, 5, 20),
                },
                new Department
                {
                    Dept_Name = "Electrical Engineering",
                    Dept_Desc = "Covers electrical systems, circuits, and power generation.",
                    Dept_Location = "Building B",
                    Manager_hiredate = new DateTime(2016, 7, 12),
                },
                new Department
                {
                    Dept_Name = "Mechanical Engineering",
                    Dept_Desc = "Deals with mechanics, kinematics, and thermodynamics.",
                    Dept_Location = "Building C",
                    Manager_hiredate = new DateTime(2014, 3, 15),
                },
                new Department
                {
                    Dept_Name = "Civil Engineering",
                    Dept_Desc = "Focuses on infrastructure, construction, and environmental engineering.",
                    Dept_Location = "Building D",
                    Manager_hiredate = new DateTime(2017, 9, 25),
                },
                new Department
                {
                    Dept_Name = "Business Administration",
                    Dept_Desc = "Covers management, finance, and marketing principles.",
                    Dept_Location = "Building E",
                    Manager_hiredate = new DateTime(2018, 11, 30),
                }
            };


        }
    }
}
