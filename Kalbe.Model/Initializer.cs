using System.Data.Entity;

namespace Kalbe.Model
{
    class Initializer : DropCreateDatabaseAlways<DataContext>
    {
        protected override void Seed(DataContext context)
        {

        }
    }
}