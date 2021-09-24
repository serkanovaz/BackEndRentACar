using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, RentACarContext>, ICustomerDal
    {
        public List<CustomerDetailDto> getCustomerDetails(Expression<Func<Customer, bool>> filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in filter is null ? context.Customers : context.Customers.Where(filter)
                             join u in context.Users
                                 on c.UserId equals u.Id
                             select new CustomerDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status,
                             };
                return result.ToList();
            }
        }

        public CustomerDetailDto getCustomerDetailById(Expression<Func<Customer, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in filter is null ? context.Customers : context.Customers.Where(filter)
                             join u in context.Users
                                 on c.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 CompanyName = c.CompanyName,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status,
                             };
                return result.FirstOrDefault();
            }
        }

        public CustomerDetailDto getCustomerByEmail(Expression<Func<CustomerDetailDto, bool>> filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var result = from c in context.Customers
                             join u in context.Users
                                 on c.UserId equals u.Id

                             select new CustomerDetailDto
                             {
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 Email = u.Email,
                                 Status = u.Status,
                                 CompanyName = c.CompanyName
                             };
                return result.SingleOrDefault(filter);
            }
        }


    }
}

