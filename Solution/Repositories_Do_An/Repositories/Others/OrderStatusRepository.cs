﻿using Repositories_Do_An.DBcontext_vs_Entities;
using Repositories_Do_An.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories_Do_An.Repositories
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private CFcontext _dbcontext;
        public OrderStatusRepository(CFcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool create(OrderStatus entity)
        {
            try
            {
                _dbcontext.OrderStatuss.Add(entity);
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

        public bool delete(OrderStatus entity)
        {
            try
            {
                _dbcontext.OrderStatuss.Remove(entity);
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

        public List<OrderStatus> getAll()
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.ToList();
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrderStatus read(int id)
        {
            try
            {
                var rs = _dbcontext.OrderStatuss.FirstOrDefault(t => t.OrderStatusId == id);
                return rs;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public OrderStatus read(string name) => null;

        public bool update(OrderStatus entity)
        {
            try
            {
                _dbcontext.OrderStatuss.Update(entity);
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


        public bool checkInitOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId).ToList();
                if(rs.Count == 1 && rs[0].StatusId==1) 
                {
                    return true;
                }
                else { return false; }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public bool checkAcceptedOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId==2).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkContractedByCustomerOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 4).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkContractedByDriverOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 3).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkDeliveringOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 5).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkDeliveredOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 6).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkTakenOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 7).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkUnTakenOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 8).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkAlteredOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 14).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkFinishedOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 10).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkPayedOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 11).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkEndOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 12).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool checkProblemOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 13).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool checkAlteringOrder(int orderId)
        {
            try
            {
                List<OrderStatus> rs = _dbcontext.OrderStatuss.Where(entity => entity.OrderId == orderId && entity.StatusId == 9).ToList();
                if (rs.Count == 0)
                {
                    return false;
                }
                else { return true; }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int checkBeforeStatus(int orderId)
        {
            try
            {
                var rs = _dbcontext.OrderStatuss.OrderByDescending(e => e.Date).Where(entity => entity.OrderId == orderId).FirstOrDefault();
                return rs.StatusId; 
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
