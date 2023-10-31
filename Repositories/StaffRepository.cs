﻿using BusinessObjects;
using DataAccessObjects;
using Repositories.Interface;

namespace Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public void AddStaff(staff staff) => StaffDAO.Instance.AddStaff(staff);

        public Boolean CheckloginforStaff(string email, string password)=> StaffDAO.CheckLoginforStaff(email, password);

        public void DeleteStaff(staff staff) => StaffDAO.Instance.DeleteStaff(staff);

        public staff GetStaffById(int id) => StaffDAO.Instance.GetStaffById(id);

        public List<staff> GetStaffs() => StaffDAO.Instance.GetStaffs();
        public void UpdateStaff(staff staff) => StaffDAO.Instance.UpdateStaff(staff);
        public staff getStaffbyEmails(string email) => StaffDAO.GetstaffbyEmail(email);
    }
}