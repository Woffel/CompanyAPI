﻿namespace Company.API.Extensions
{
    public static class HttpExtensions
    {
        public static async Task<IResult> HttpGetAsync<TEntity, TDto>(this IDbService db) where TEntity : class, IEntity where TDto : class
        {
            //return null;
            return Results.Ok(await db.GetAsync<TEntity, TDto>());
        }

        public static async Task<IResult> HttpSingleAsync<TEntity, TDto>(this IDbService db, int id) where TEntity : class, IEntity where TDto : class
        {
            var result = await db.SingleAsync<TEntity, TDto>(e => e.Id.Equals(id));
            if (result == null)
            {
                return Results.NotFound();
            }
            else
            {
                return Results.Ok(result);
            }
        }

        public static async Task<IResult> HttpPostAsync<TEntity, TDto>(this IDbService db, TDto dto) where TEntity : class where TDto : class
        {
            try
            {
                var entity = await db.AddAsync<TEntity, TDto>(dto);
                if (await db.SaveChangesAsync())
                {
                    var node = typeof(TEntity).Name.ToLower();
                    return Results.Created($"{node} / {entity}", entity);
                }
            }
            catch (Exception e)
            {
                return Results.BadRequest($"Couldn't add the {typeof(TEntity).Name} entity.\n{e}.");
            }
            return Results.BadRequest($"Couldn't add the {typeof(TEntity).Name} entity.");
        }

        public static async Task<IResult> HttpPutAsync<TEntity, TDto>(this IDbService db, int id, TDto dto) where TEntity : class, IEntity where TDto : class
        {
            try
            {
                if (!await db.AnyAsync<TEntity>(e => e.Id.Equals(id))) return Results.NotFound();
                db.Update<TEntity, TDto>(id, dto);
                if (await db.SaveChangesAsync()) return Results.NoContent();
            }
            catch (Exception e)
            {
                return Results.BadRequest($"Couldn't update the {typeof(TEntity).Name} entity.\n{e}.");
            }
            return Results.BadRequest($"Couldn't update the {typeof(TEntity).Name} entity.");
        }

        public static async Task<IResult> HttpDeleteAsync<TEntity>(this IDbService db, int id) where TEntity : class, IEntity
        {
            try
            {
                if (!await db.DeleteAsync<TEntity>(id)) return Results.NotFound();
                if (await db.SaveChangesAsync()) return Results.NoContent();
            }
            catch (Exception e)
            {
                return Results.BadRequest($"Couldn't delete the {typeof(TEntity).Name} entity.\n{e}.");
            }
            return Results.BadRequest($"Couldn't delete the {typeof(TEntity).Name} entity.");
        }

        public static async Task<IResult> HttpDeleteAsync<TReferenceEntity, TDto>(this IDbService db, TDto dto) where TReferenceEntity : class where TDto : class
        {
            try
            {
                if (!db.Delete<TReferenceEntity, TDto>(dto)) return Results.NotFound();
                if(await db.SaveChangesAsync()) return Results.NoContent();

            }
            catch (Exception e)
            {
                return Results.BadRequest(e);
            }
            return Results.Ok();
        }
        public static async Task<IResult> HttpAddAsync<TReferenceEntity, TDto>(this IDbService db, TDto dto) where TReferenceEntity : class where TDto : class
        {
            try
            {
                var entity = await db.AddAsync<TReferenceEntity, TDto>(dto);
                if (await db.SaveChangesAsync())
                {
                    var node = typeof(TReferenceEntity).Name.ToLower();
                    return Results.Created($"{node} / {entity}", entity);
                }
            }
            catch (Exception e)
            {
                return Results.BadRequest($"Couldn't add the {typeof(TReferenceEntity).Name} entity.\n{e}.");
            }
            return Results.BadRequest($"Couldn't add the {typeof(TReferenceEntity).Name} entity.");
        }


    }
}
