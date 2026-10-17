using college.AppForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college.Services
{
    class FormManager
    {
        private static Stack<ParentForm> _history = new Stack<ParentForm>();

        public static void NavigateTo(ParentForm newForm, ParentForm currentForm, bool log = true)

        {
            if (log == true)

            {
                _history.Push(currentForm);
            }

            newForm.Show();

            currentForm.Hide();

        }
        public static void GoBack(ParentForm currentForm)

        {

            currentForm.Hide();

            ParentForm historycalForm = _history.Pop();


            Type historicalFormType = historycalForm.GetType();

            var newForm = (ParentForm)Activator.CreateInstance(historicalFormType);

            newForm.EntityId = historycalForm.EntityId;


            newForm.Show();

        }
    }
}
