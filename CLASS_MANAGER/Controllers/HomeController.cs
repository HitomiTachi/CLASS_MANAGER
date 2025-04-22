// HomeController.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CLASS_MANAGER.Models;
using Microsoft.AspNetCore.Mvc;

namespace CLASS_MANAGER.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            // Create sample data for the view
            var viewModel = new HomeViewModel
            {
                Assignments = GetSampleAssignments(),
                Members = GetSampleMembers(),
                Announcements = GetSampleAnnouncements(),
                Schools = GetSampleSchools()
            };

            return View(viewModel);
        }

        public ActionResult Privacy()
        {
            return View();
        }

        #region Sample Data Methods
        private List<Assignment> GetSampleAssignments()
        {
            return new List<Assignment>
            {
                new Assignment
                {
                    Id = 1,
                    Title = "Bài tập Java cơ bản",
                    Description = "Tổng hợp các bài tập Java cơ bản dành cho sinh viên năm nhất ngành Công nghệ thông tin.",
                    ImageUrl = "/Content/images/java.jpg"
                },
                new Assignment
                {
                    Id = 2,
                    Title = "Phân tích thiết kế hệ thống",
                    Description = "Hướng dẫn phân tích và thiết kế hệ thống theo chuẩn UML cho sinh viên ngành Công nghệ phần mềm.",
                    ImageUrl = "/Content/images/uml.jpg"
                },
                new Assignment
                {
                    Id = 3,
                    Title = "Lập trình website ASP.NET MVC 5",
                    Description = "Xây dựng website quản lý sử dụng công nghệ ASP.NET MVC 5 và Entity Framework.",
                    ImageUrl = "/Content/images/aspnet.jpg"
                },
                new Assignment
                {
                    Id = 4,
                    Title = "Lập trình di động",
                    Description = "Hướng dẫn xây dựng ứng dụng Android Studio cho sinh viên năm cuối.",
                    ImageUrl = "/Content/images/android.jpg"
                }
            };
        }

        private List<Member> GetSampleMembers()
        {
            return new List<Member>
            {
                new Member
                {
                    Id = 1,
                    Name = "Nguyễn Văn A",
                    StudentId = "SV001",
                    Class = "CNTT1",
                    Role = MemberRole.Teacher
                },
                new Member
                {
                    Id = 2,
                    Name = "Trần Thị B",
                    StudentId = "SV002",
                    Class = "CNTT1",
                    Role = MemberRole.ClassLeader
                },
                new Member
                {
                    Id = 3,
                    Name = "Lê Văn C",
                    StudentId = "SV003",
                    Class = "CNTT2",
                    Role = MemberRole.Student
                },
                new Member
                {
                    Id = 4,
                    Name = "Phạm Thị D",
                    StudentId = "SV004",
                    Class = "CNTT2",
                    Role = MemberRole.Student
                }
            };
        }

        private List<Announcement> GetSampleAnnouncements()
        {
            return new List<Announcement>
            {
                new Announcement
                {
                    Id = 1,
                    Title = "Lịch kiểm tra giữa kỳ môn Lập trình Web",
                    Author = "GV. Nguyễn Văn A",
                    Date = new DateTime(2025, 4, 20),
                    Status = AnnouncementStatus.Important
                },
                new Announcement
                {
                    Id = 2,
                    Title = "Thông báo nghỉ học ngày 25/04/2025",
                    Author = "GV. Trần Thị B",
                    Date = new DateTime(2025, 4, 18),
                    Status = AnnouncementStatus.Normal
                },
                new Announcement
                {
                    Id = 3,
                    Title = "Hướng dẫn nộp bài tập lớn",
                    Author = "GV. Lê Văn C",
                    Date = new DateTime(2025, 4, 15),
                    Status = AnnouncementStatus.Warning
                }
            };
        }

        private List<School> GetSampleSchools()
        {
            return new List<School>
            {
                new School { Id = 1, Name = "HUTECH" },
                new School { Id = 2, Name = "ĐH N.T THÀNH" },
                new School { Id = 3, Name = "CĐ CNTT TP.HCM" },
                new School { Id = 4, Name = "ĐH KTKT B.DƯƠNG" },
                new School { Id = 5, Name = "ĐH CN TP TPHCM" }
            };
        }
        #endregion
    }
}