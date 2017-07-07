using Seed.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Seed.EntityFramework;

namespace Seed.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/products
        public IHttpActionResult Get()
        {
            try
            {
                using (var ctx = new BP_DB())
                {
                    return Ok(ctx.Products.ToList());
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // GET: api/products/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                using (var ctx = new BP_DB())
                {
                    var product = ctx.Products.FirstOrDefault(r => r.ProductID == id);
                    if (product == null)
                    {
                        return NotFound();
                    }
                    return Ok(product);
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // POST: api/products
        public IHttpActionResult Post([FromBody]Product value)
        {
            try
            {
                using (var ctx = new BP_DB())
                {
                    var product = ctx.Products.FirstOrDefault(r => r.ProductID == value.ProductID);
                    if (product == null)
                    {
                        ctx.Products.Add(value);
                    }
                    else
                    {
                        ctx.Products.Attach(value);
                        var entry = ctx.Entry(value);
                        entry.State = System.Data.Entity.EntityState.Modified;
                    }
                    ctx.SaveChanges();
                    return Ok(value);
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // PUT: api/Products/5
        public IHttpActionResult Put(int id, [FromBody]Product value)
        {
            try
            {
                using (var ctx = new BP_DB())
                {
                    var product = ctx.Products.FirstOrDefault(r => r.ProductID == id);
                    if (product == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ctx.Products.Attach(value);
                        var entry = ctx.Entry(value);
                        entry.State = System.Data.Entity.EntityState.Modified;
                        ctx.SaveChanges();
                        return Ok(value);
                    }
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }

        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                using (var ctx = new BP_DB())
                {
                    var product = ctx.Products.FirstOrDefault(r => r.ProductID == id);
                    if (product == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        ctx.Products.Remove(product);
                        ctx.SaveChanges();
                        return Ok(product);
                    }
                }
            }
            catch (Exception e)
            {
                return InternalServerError(e);
            }
        }
    }
}
