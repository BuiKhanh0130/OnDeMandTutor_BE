﻿using BusinessObjects;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IFeedbackRepository
    {
        public bool AddFeedback(Feedback feedback);

        public bool DelFeedbacks(int id);

        public List<Feedback> GetFeedbacks(string id);

        public bool UpdateFeedbacks(Feedback feedback);

        Task<List<FeedbackVMPhuc>> GetAllFeedBack();
    }
}
