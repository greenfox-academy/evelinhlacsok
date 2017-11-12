﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Reddit.Entities;
using Reddit.Models;

namespace Reddit.Repositories
{
    public class ContentRepository
    {
        ContentContext contentContext;

        public ContentRepository (ContentContext contentContext)
        {
            this.contentContext = contentContext;
        }

        public List<Content>GetList()
        {
            return contentContext.Contents.ToList();
        }
    }
}
