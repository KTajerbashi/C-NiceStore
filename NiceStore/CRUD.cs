﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceStore
{
    public class CRUD
    {
        NiceStoreDBEntities DB = new NiceStoreDBEntities();

        public bool CreatCustomer(CustomerTB customer)
        {
            foreach (var item in DB.CustomerTBs)
            {
                if(item.Name==customer.Name && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            DB.CustomerTBs.Add(customer);
            DB.SaveChanges();
            return true;
        }
        public bool EditCustomer(CustomerTB customer)
        {
            foreach (var item in DB.CustomerTBs)
            {
                if(item.id != customer.id && item.Name==customer.Name && item.Phone == customer.Phone)
                {
                    return false;
                }
            }
            CustomerTB Customer = DB.CustomerTBs.Where(c => c.id == customer.id).FirstOrDefault();
            Customer.Name = customer.Name;
            Customer.Phone = customer.Phone;
            DB.SaveChanges();
            return true;
        }
        public void DeleteCustomer(int id)
        {
            CustomerTB customer = (DB.CustomerTBs.Where(c => c.id == id).FirstOrDefault());
            DB.CustomerTBs.Remove(customer);
            DB.SaveChanges();
        }


        public bool CreatPhone(PhoneTB phone)
        {
            foreach (var item in DB.PhoneTBs)
            {
                if (item.Name == phone.Name && item.Barcode == phone.Barcode && item.Brand==phone.Brand)
                {
                    return false;
                }
            }
            DB.PhoneTBs.Add(phone);
            DB.SaveChanges();
            return true;
        }
        public bool EditPhone(PhoneTB phone)
        {
            foreach (var item in DB.PhoneTBs)
            {
                if (item.ID != phone.ID && item.Name == phone.Name && item.Brand == phone.Brand)
                {
                    return false;
                }
            }
            PhoneTB phones = DB.PhoneTBs.Where(c => c.ID == phone.ID).FirstOrDefault();
            phones.Barcode = phone.Barcode;
            phones.Name = phone.Name;
            phones.Price = phone.Price;
            phones.Mojod = phone.Mojod;
            phones.Brand = phone.Brand;
            phones.CPU = phone.CPU;
            phones.ScreenSize = phone.ScreenSize;
            phones.RAM = phone.RAM;
            DB.SaveChanges();
            return true;
        }
        public void DeletePhone(int id)
        {
            PhoneTB phone = (DB.PhoneTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.PhoneTBs.Remove(phone);
            DB.SaveChanges();
        }

        public bool CreatTools(ToolsTB tool)
        {
            foreach (var item in DB.ToolsTBs)
            {
                if (item.Name == tool.Name && item.Barcode == tool.Barcode )
                {
                    return false;
                }
            }
            DB.ToolsTBs.Add(tool);
            DB.SaveChanges();
            return true;
        }
        public bool EditTools(ToolsTB tool)
        {
            foreach (var item in DB.ToolsTBs)
            {
                if ( item.ID != tool.ID && item.Name == tool.Name )
                {
                    return false;
                }
            }
            ToolsTB tools = DB.ToolsTBs.Where(c => c.ID == tool.ID).FirstOrDefault();
            tools.Barcode = tool.Barcode;
            tools.Name = tool.Name;
            tools.Price = tool.Price;
            tools.Mojodi = tool.Mojodi;
            tools.Type = tool.Type;
            DB.SaveChanges();
            return true;
        }
        public void DeleteTools(int id)
        {
            ToolsTB tools = (DB.ToolsTBs.Where(c => c.ID == id).FirstOrDefault());
            DB.ToolsTBs.Remove(tools);
            DB.SaveChanges();
        }



    }
}