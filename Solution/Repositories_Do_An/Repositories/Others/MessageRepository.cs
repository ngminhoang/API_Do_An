﻿using Repositories_Do_An.DBcontext_vs_Entities;
using Repositories_Do_An.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace Repositories_Do_An.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private CFcontext _dbcontext;
        public MessageRepository(CFcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool create(Message entity)
        {
            try
            {
                _dbcontext.Messages.Add(entity);
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

        public bool delete(Message entity)
        {
            try
            {
                _dbcontext.Messages.Remove(entity);
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

        public List<Message> getAll()
        {
            try
            {
                List<Message> rs = _dbcontext.Messages.ToList();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Message> getAll(int userId, int roleId)
        {
            try
            {
                List<Message> rs = _dbcontext.Messages.Where(x=> x.UserId == roleId && x.RoleId ==roleId).ToList();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Message read(int id)
        {
            try
            {
                var rs = _dbcontext.Messages.FirstOrDefault(t => t.MessId == id);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Message read(string name) => null;

        public bool update(Message entity)
        {
            try
            {
                _dbcontext.Messages.Update(entity);
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
