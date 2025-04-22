// Models/HomeViewModel.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CLASS_MANAGER.Models
{
    public class HomeViewModel
    {
        public List<Assignment> Assignments { get; set; }
        public List<Member> Members { get; set; }
        public List<Announcement> Announcements { get; set; }
        public List<School> Schools { get; set; }
    }

    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }

    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StudentId { get; set; }
        public string Class { get; set; }
        public MemberRole Role { get; set; }
    }

    public enum MemberRole
    {
        Student,
        ClassLeader,
        Teacher
    }

    public class Announcement
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime Date { get; set; }
        public AnnouncementStatus Status { get; set; }
    }

    public enum AnnouncementStatus
    {
        Normal,
        Warning,
        Important
    }

    public class School
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}