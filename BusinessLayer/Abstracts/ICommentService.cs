﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstracts
{
    public interface ICommentService
    {
        void CommentAdd(Comment comment);
        void CommentDelete(Comment comment);
        void CommentUpdate(Comment comment);

        List<Comment> GetList(int id );
        List<Comment> GetAllList();
        Comment GetById(int id);

        List<Comment> GetListWithBlog();
    }
}
