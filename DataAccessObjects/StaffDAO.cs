﻿using BusinessObjects;
using System.ComponentModel.Design;
using DataAccessObjects.ResponseModel;

namespace DataAccessObjects
{
    public class StaffDAO
    {
        private static StaffDAO instance = null;
        private static readonly object instanceLock = new object();

        private StaffDAO() { }

        public static StaffDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDAO();
                    }
                    return instance;
                }
            }
        }
        public List<staff> GetStaffs()
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.staff.Where(p=> p.Active == true).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        public staff GetStaffById(int id)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.staff.SingleOrDefault(s => s.Active == true && s.StaffId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Please enter Again");
            }
        }
        public void AddStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    context.staff.Add(staff);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw ;
            }
        }
        public void UpdateStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    var staffToUpdate = context.staff.Find(staff.StaffId);
                    {
                        staffToUpdate.StaffName = staff.StaffName;
                        staffToUpdate.Email = staff.Email;
                        staffToUpdate.Phone = staff.Phone;
                        staffToUpdate.Dob = staff.Dob;
                        staffToUpdate.Sex = staff.Sex;
                        staffToUpdate.Status = staff.Status;
                        staffToUpdate.ServiceId = staff.ServiceId;

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void DeleteStaff(staff staff)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    //context.staff.Remove(staffToDelete);
                    var exitstingstaff = context.staff.SingleOrDefault(p => p.StaffId == staff.StaffId);
                    if (exitstingstaff != null)
                    {
                        exitstingstaff.Active = false;
                        context.SaveChanges();
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static Boolean CheckLoginforStaff(String email, String password)
        {
            try
            {
                using (var Context = new StudentHouseMembershipContext())
                {
                    var temp = Context.staff.SingleOrDefault(p => p.Email == email
                    && p.Password == password&& p.Active == true);
                    if (temp != null)
                    { return true; }

                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message + "");

            }




        }

        public static List<int> getStaffAvailable()
        {
            try
            {

                using (var context = new StudentHouseMembershipContext())
                {


                    var staffId = context.staff.Where(p => p.Status == "false" && p.Active == true)
                            .Select(p => p.StaffId).ToList();
                    return staffId;


                }




            }
            catch (Exception e)
            {

                throw e;

            }
        }
            public static List<staff> SearchbyStatus(string Status)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                    List<staff> staffList = context.staff.Where(p => p.Status == Status && p.Active ==true).ToList();
                    return staffList;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static staff GetstaffbyEmail(String email)
        {
            staff getStaff = new staff();
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {

                    getStaff = context.staff.SingleOrDefault(m => m.Email == email);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return getStaff;
        }

        public static List<StaffOrderModel> GetStaffOrder(int staffId)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    List<StaffOrderModel> result = new List<StaffOrderModel>();
                    //lay order of staff 
                    List<StaffOrder> ordersOfStaff = context.StaffOrders.Where(x => x.StaffId == staffId).ToList();

                    foreach (var orderOfStaff in ordersOfStaff)
                    {
                        StaffOrderModel staffOrderModel = null;
                        // lay orderId -> descripttion , Inprocess
                        Order order = context.Orders.Where(x => x.OrderId == orderOfStaff.OrderId).FirstOrDefault();
                        if (order != null)
                        {
                            List<OrderDetail> orderDetails = context.OrderDetails.Where(x => x.OrderId == order.OrderId).ToList();
                            staffOrderModel = new StaffOrderModel(staffId, orderOfStaff.OrderId, orderOfStaff.WorkDate, orderOfStaff.Status, order.Description, orderDetails);

                            result.Add(staffOrderModel);

                        }
                    }

                    return result;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static List<OrderDetail> GetStaffOrderDetails(int orderId)
        {
            try
            {
                using (var context = new StudentHouseMembershipContext())
                {
                    return context.OrderDetails.Where(x => x.OrderId == orderId).ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool StaffIdExists(int staffId)
        {
            using (var context = new StudentHouseMembershipContext()) // Replace with your actual DbContext
            {
                return context.staff.Any(s => s.StaffId == staffId);
            }
        }
    }
}
