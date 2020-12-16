using toDosMvc.Models;
using System;
using Microsoft.EntityFrameworkCore;

public class BaseRepository<T> where T:BaseModel{
    protected private readonly DbSet<T> dbSet;
    protected private readonly ApplicationContext context;

    public BaseRepository(ApplicationContext context){
        this.context = context;
        this.dbSet = context.Set<T>();
    }
}