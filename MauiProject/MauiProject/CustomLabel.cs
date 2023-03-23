using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiProject
{
    public class CustomLabel : Label
    {
        public bool IsLabelMeasured;

        public CustomLabel()
        {
            this.IsLabelMeasured = false;
        }

        protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
        {
            this.IsLabelMeasured = true;
            return base.MeasureOverride(widthConstraint, heightConstraint);
        }
    }
}
