﻿using Shared.Infrastructure.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetClub.Domain.Entity
{
    public class CommentVote : IEntity
    {
        public long UserID { get; set; }

        public long CommentID { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
