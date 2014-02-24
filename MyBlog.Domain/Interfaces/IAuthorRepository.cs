﻿using System.Collections.Generic;
using MyBlog.Domain.Entities;

namespace MyBlog.Domain.Interfaces
{
    /// <summary>
    /// Interface for the author repository.
    /// </summary>
    public interface IAuthorRepository : IRepository<Author>
    {
        List<Author> GetAuthors();
    }
}
