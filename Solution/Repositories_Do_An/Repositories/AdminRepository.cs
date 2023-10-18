﻿using Repositories_Do_An.DBcontext_vs_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.Repositories
{
    public class AdminRepository : IRepository<Admin>
    {
        private CFcontext _dbcontext;
        public AdminRepository(CFcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool create(Admin entity)
        {
            try
            {
                _dbcontext.Admins.Add(entity);
                _dbcontext.SaveChanges();
                try
                {
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool delete(Admin entity)
        {
            try
            {
                _dbcontext.Admins.Remove(entity);
                _dbcontext.SaveChanges();
                try
                {
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Admin> getAll()
        {
            try
            {
                List<Admin> rs = _dbcontext.Admins.ToList();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Admin read(int id)
        {
            try
            {
                var rs = _dbcontext.Admins.FirstOrDefault(t => t.UserId == id);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Admin read(string name)
        {
            try
            {
                var rs = _dbcontext.Admins.FirstOrDefault(t => t.FullName == name);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool update(Admin entity)
        {
            try
            {
                _dbcontext.Admins.Add(entity);
                _dbcontext.SaveChanges();
                try
                {
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
