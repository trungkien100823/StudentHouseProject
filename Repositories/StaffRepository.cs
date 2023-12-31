﻿using BusinessObjects;
using DataAccessObjects;
using DataAccessObjects.ResponseModel;


namespace Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public void AddStaff(staff staff) => StaffDAO.Instance.AddStaff(staff);

        public Boolean CheckloginforStaff(string email, string password) => StaffDAO.CheckLoginforStaff(email, password);

        public void DeleteStaff(staff staff) => StaffDAO.Instance.DeleteStaff(staff);

        public staff GetStaffById(int id) => StaffDAO.Instance.GetStaffById(id);

        public List<staff> GetStaffs() => StaffDAO.Instance.GetStaffs();

        public void UpdateStaff(staff staff) => StaffDAO.Instance.UpdateStaff(staff);

        public staff getStaffbyEmails(string email) => StaffDAO.GetstaffbyEmail(email);

        public List<StaffOrderModel> GetStaffOrder(int staffId) => StaffDAO.GetStaffOrder(staffId);

        public List<OrderDetail> GetStaffOrderDetails(int orderId) => StaffDAO.GetStaffOrderDetails(orderId);

        public bool StaffIdExists(int id) => StaffDAO.StaffIdExists(id);
        public List<staff> GetStaffbyStatus(string Status) =>StaffDAO.SearchbyStatus(Status);

        public List<int> getStaffByAvailable() => StaffDAO.getStaffAvailable();
    }
}
