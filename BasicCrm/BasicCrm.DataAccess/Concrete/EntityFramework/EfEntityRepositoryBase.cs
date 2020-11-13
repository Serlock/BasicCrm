using BasicCrm.DataAccess.Abstract;
using BasicCrm.Entities.Abstract;
using BasicCrm.Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BasicCrm.DataAccess.Concrete.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        Admin admin;
        Customer customer;
        string sqlCommand;
        public TEntity Get(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                admin = entity as Admin;
                customer = entity as Customer;

                if (admin != null)
                {
                    sqlCommand = "exec sp_GetAdmin " +
                        "@AdminName = '" + admin.AdminName + "', " +
                        "@AdminPassword = '" + admin.AdminPassword + "'";
                }
                else if (customer != null)
                {
                    sqlCommand = "exec sp_GetCustomer " +
                        "@Id = '" + customer.Id + "'";
                }

                return context.Set<TEntity>().FromSqlRaw(sqlCommand).ToList().FirstOrDefault();
            }
        }

        public List<TEntity> GetAll(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                admin = entity as Admin;
                customer = entity as Customer;

                if (admin != null)
                {
                    sqlCommand = "exec sp_GetAllAdmins " +
                        "@AdminId = '" + admin.AdminId + "', " +
                        "@AdminName = '" + admin.AdminName + "'";
                }
                else if (customer != null)
                {
                    string gender = customer.Gender == '\0' ? null : customer.Gender.ToString();
                    sqlCommand = "exec sp_GetAllCustomers " +
                        "@Id = '" + customer.Id + "', " +
                        "@Name = '" + customer.Name + "', " +
                        "@SurName = '" + customer.SurName + "', " +
                        "@Age = '" + customer.Age + "', " +
                        "@Gender = '" + gender + "', " +
                        "@Job = '" + customer.Job + "', " +
                        "@City = '" + customer.City + "'";
                }

                return context.Set<TEntity>().FromSqlRaw(sqlCommand).ToList();
            }
        }

        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                admin = entity as Admin;
                customer = entity as Customer;

                if (admin != null)
                {
                    sqlCommand = "exec sp_AddAdmin " +
                        "@AdminName = '" + admin.AdminName + "', " +
                        "@AdminPassword = '" + admin.AdminPassword + "'";
                }
                else if (customer != null)
                {
                    sqlCommand = "exec sp_AddCustomer " +
                        "@Name = '" + customer.Name + "', " +
                        "@SurName = '" + customer.SurName + "', " +
                        "@Age = '" + customer.Age + "', " +
                        "@Gender = '" + customer.Gender + "', " +
                        "@Job = '" + customer.Job + "', " +
                        "@City = '" + customer.City + "'";
                }

                context.Database.ExecuteSqlRaw(sqlCommand);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                admin = entity as Admin;
                customer = entity as Customer;

                if (admin != null)
                {
                    sqlCommand = "exec sp_DeleteAdmin " +
                        "@AdminId='" + admin.AdminId + "'";
                }
                else if (customer != null)
                {
                    sqlCommand = "exec sp_DeleteCustomer " +
                        "@Id='" + customer.Id+ "'";
                }

                context.Database.ExecuteSqlRaw(sqlCommand);
                context.SaveChanges();
            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                admin = entity as Admin;
                customer = entity as Customer;

                if (admin != null)
                {
                    sqlCommand = "exec sp_UpdateAdmin " +
                        "@AdminId = '" + admin.AdminId + "', " +
                        "@AdminName = '" + admin.AdminName + "', " +
                        "@AdminPassword = '" + admin.AdminPassword + "'";
                }
                else if (customer != null)
                {
                    sqlCommand = "exec sp_UpdateCustomer " +
                        "@Id = '" + customer.Id + "', " +
                        "@Name = '" + customer.Name + "', " +
                        "@SurName = '" + customer.SurName + "', " +
                        "@Age = '" + customer.Age + "', " +
                        "@Gender = '" + customer.Gender + "', " +
                        "@Job = '" + customer.Job + "', " +
                        "@City = '" + customer.City + "'";
                }

                context.Database.ExecuteSqlRaw(sqlCommand);
                context.SaveChanges();
            }
        }
    }
}
