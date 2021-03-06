﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Eagle.Data.Queries.Criterias
{
    public class OrSqlCriteria : CompositeSqlCriteria, ICompositeSqlCriteria
    {
        public OrSqlCriteria(ISqlCriteria left, ISqlCriteria right) : base(left, right) { }

        public override string GetSqlCriteria()
        {
            return string.Format(" {0} {1} {2} ", this.Left.GetSqlCriteria(), this.GetOperatorChar(), this.Right.GetSqlCriteria());
        }

        protected override string GetOperatorChar()
        {
            return "OR";
        }
    }
}
