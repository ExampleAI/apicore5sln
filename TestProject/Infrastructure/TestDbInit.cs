using Microsoft.EntityFrameworkCore;
using xAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xAI.Data;

namespace TestProject.Infrastructure
{
    class xAIInitializer
    {
        public static void Initialize(xAIContext context)
        {
//[SEEDDBINIT]

            Seed(context);

        }

        private static void Seed(xAIContext context)
        {
//[SEEDDB]
        }
    }
}

