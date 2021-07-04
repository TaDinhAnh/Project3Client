﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
namespace Client.ServiceAPI
{
    public interface IQuestionAPI
    {
        List<Question> findAll();
        List<Question> Create(Question question);
        List<Question> delQuestion(int idQuestion);
        Question DetailQuestion(int idQuestion);
        Question Update(Question question);
    }
}
