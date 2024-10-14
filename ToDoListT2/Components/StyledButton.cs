using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListT2.Components
{
    public partial class StyledButton : Component
    {
        public StyledButton()
        {
            InitializeComponent();
        }

        public StyledButton(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
