﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queue.Algorithm.Data;

namespace Queue.Algorithm
{
    public interface IJacksonSolver
    {
        Output Solve(Input input);
    }

    class JacksonSolver : IJacksonSolver
    {
        private readonly IParametersSolver _parametersSolver;

        public JacksonSolver(IParametersSolver parametersSolver)
        {
            _parametersSolver = parametersSolver;
        }

        public Output Solve(Input input)
        {
            var parameters = Enumerable.Empty<SystemStatistics>();

            return CreateResult(parameters.ToArray());
        }

        private Output CreateResult(SystemStatistics[] parameters)
        {
            return new Output
            {
                Time = parameters.Sum(x => x.ServiceTime),
                SystemStats = parameters
            };
        }
    }
}