using Question.DAL;
using System.Linq;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class RezaltTrain : Form
    {
        MyContext context = new MyContext();
        public User UserRes { get; set; }

        public RezaltTrain(TrainingForm train)
        {
            InitializeComponent();
            UserRes = train.ResUser;            
            var user = context.Users.SingleOrDefault(x => x.Id == UserRes.Id);
            label1.Text = $"{user.Surname} {user.Name}";

            int uncorrect = train.newlistcount - train.rightans;
            label2.Text = $"Всього пройдено запитань: {train.newlistcount}";
            label3.Text = $"Кількість правильних відповідей: {train.rightans}";
            label4.Text = $"Кількість неправильних відповідей: {uncorrect}";
            label5.Text = $"Пройдено тест на: {(train.rightans * 100)/train.newlistcount} %";

            //if(uncorrect>2)
            //{
            //    label6.Text= "У вас більше 2 помилок! Вчіть далі!";
            //}
            //else
            //{
            //    label6.Text=" ";
            //}

        }
    }
}
