using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WearApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonWork_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            IDirector director = new DirectorWork();
            IBuilder work = new WorkWear();
            director.Construct(work);
            Product workWear = work.GetResult();
            workWear.Show(g);
        }

        private void buttonStudy_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            IDirector director = new DirectorStudy();
            IBuilder study = new StudyWear();
            director.Construct(study);
            Product studyWear = study.GetResult();
            studyWear.Show(g);
        }

        private void buttonDisco_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            IDirector director = new DirectorDisco();
            IBuilder disco = new DiscoWear();
            director.Construct(disco);
            Product discoWear = disco.GetResult();
            discoWear.Show(g);
        }

        private void buttonSleep_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);
            IDirector director = new DirectorSleep();
            IBuilder sleep = new SleepWear();
            director.Construct(sleep);
            Product sleepWear = sleep.GetResult();
            sleepWear.Show(g);
        }
    }


    interface IDirector
    {
        void Construct(IBuilder builder);
    }

    // "Director" 

    class DirectorWork:IDirector
    {
        // Builder uses a complex series of steps 
        public void Construct(IBuilder builder)
        {
            builder.BuildHat1();
            builder.BuildTop1();
            builder.BuildBottom1();
            builder.BuildShoes1();
        }
    }

    class DirectorStudy : IDirector
    {
        // Builder uses a complex series of steps 
        public void Construct(IBuilder builder)
        {
            builder.BuildHat1();
            builder.BuildTop1();
            builder.BuildBottom1();
            builder.BuildShoes1();
        }
    }

    class DirectorDisco : IDirector
    {
        // Builder uses a complex series of steps 
        public void Construct(IBuilder builder)
        {
            builder.BuildHat1();
            builder.BuildTop1();
            builder.BuildBottom1();
            builder.BuildShoes1();
        }
    }

    class DirectorSleep : IDirector
    {
        // Builder uses a complex series of steps 
        public void Construct(IBuilder builder)
        {
            
            builder.BuildTop1();
            builder.BuildBottom1();
            builder.BuildShoes1();
        }
    }

    // "Builder" 

    interface IBuilder
    {
        void BuildHat1();
        void BuildTop1();
        void BuildBottom1();
        void BuildShoes1();
        void BuildHat2();
        void BuildTop2();
        void BuildBottom2();
        void BuildShoes2();
        Product GetResult();
    }

    // "WorkWear" 

    class WorkWear : IBuilder
    {
        private Product product = new Product();

        public void BuildHat1()
        {
            product.Add(@"Woman\Работа\hat1.png", new PointF(180, -30));
        }

        public void BuildHat2()
        {
            product.Add(@"Woman\Работа\hat2.png", new PointF(180, -30));
        }

        public void BuildTop1()
        {
            product.Add(@"Woman\Работа\top1.png", new PointF(150, 40));
        }

        public void BuildTop2()
        {
            product.Add(@"Woman\Работа\top2.png", new PointF(150, 40));
        }

        public void BuildBottom1()
        {
            product.Add(@"Woman\Работа\bottom1.png", new PointF(150, 180));
        }

        public void BuildBottom2()
        {
            product.Add(@"Woman\Работа\bottom2.png", new PointF(150, 180));
        }

        public void BuildShoes1()
        {
            product.Add(@"Woman\Работа\shoes1.png", new PointF(100, 320));
            product.Add(@"Woman\Работа\shoes1.png", new PointF(200, 320));
        }

        public void BuildShoes2()
        {
            product.Add(@"Woman\Работа\shoes2.png", new PointF(100, 320));
            product.Add(@"Woman\Работа\shoes2.png", new PointF(200, 320));
        }

        public Product GetResult()
        {
            return product;
        }
    }

    // "StudyWear" 

    class StudyWear : IBuilder
    {
        private Product product = new Product();

        public void BuildHat1()
        {
            product.Add(@"Woman\Учеба\hat1.png", new PointF(180, -30));
        }

        public void BuildHat2()
        {
            product.Add(@"Woman\Учеба\hat2.png", new PointF(180, -30));
        }

        public void BuildTop1()
        {
            product.Add(@"Woman\Учеба\top1.png", new PointF(150, 40));
        }

        public void BuildTop2()
        {
            product.Add(@"Woman\Учеба\top2.png", new PointF(150, 40));
        }

        public void BuildBottom1()
        {
            product.Add(@"Woman\Учеба\bottom1.png", new PointF(150, 180));
        }

        public void BuildBottom2()
        {
            product.Add(@"Woman\Учеба\bottom2.png", new PointF(150, 180));
        }

        public void BuildShoes1()
        {
            product.Add(@"Woman\Учеба\shoes1.png", new PointF(100, 320));
            product.Add(@"Woman\Учеба\shoes1.png", new PointF(200, 320));
        }

        public void BuildShoes2()
        {
            product.Add(@"Woman\Учеба\shoes2.png", new PointF(100, 320));
            product.Add(@"Woman\Учеба\shoes2.png", new PointF(200, 320));
        }

        public Product GetResult()
        {
            return product;
        }
    }

    // "DiscoWear" 

    class DiscoWear : IBuilder
    {
        private Product product = new Product();

        public void BuildHat1()
        {
            product.Add(@"Woman\Диско\hat1.png", new PointF(180, -30));
        }

        public void BuildHat2()
        {
            product.Add(@"Woman\Диско\hat2.png", new PointF(180, -30));
        }

        public void BuildTop1()
        {
            product.Add(@"Woman\Диско\top1.png", new PointF(150, 40));
        }

        public void BuildTop2()
        {
            product.Add(@"Woman\Диско\top2.png", new PointF(150, 40));
        }

        public void BuildBottom1()
        {
            product.Add(@"Woman\Диско\bottom1.png", new PointF(150, 180));
        }

        public void BuildBottom2()
        {
            product.Add(@"Woman\Диско\bottom2.png", new PointF(150, 180));
        }

        public void BuildShoes1()
        {
            product.Add(@"Woman\Диско\shoes1.png", new PointF(100, 320));
            product.Add(@"Woman\Диско\shoes1.png", new PointF(200, 320));
        }

        public void BuildShoes2()
        {
            product.Add(@"Woman\Диско\shoes2.png", new PointF(100, 320));
            product.Add(@"Woman\Диско\shoes2.png", new PointF(200, 320));
        }

        public Product GetResult()
        {
            return product;
        }
    }

    // "SleepWear" 

    class SleepWear : IBuilder
    {
        private Product product = new Product();

        public void BuildHat1()
        {
            //product.Add(@"Woman\Сон\hat1.png", new PointF(180, -30));
        }

        public void BuildHat2()
        {
            //product.Add(@"Woman\Сон\hat2.png", new PointF(180, -30));
        }

        public void BuildTop1()
        {
            product.Add(@"Woman\Сон\top1.png", new PointF(150, 40));
        }

        public void BuildTop2()
        {
            product.Add(@"Woman\Сон\top2.png", new PointF(150, 40));
        }

        public void BuildBottom1()
        {
            product.Add(@"Woman\Сон\bottom1.png", new PointF(150, 180));
        }

        public void BuildBottom2()
        {
            product.Add(@"Woman\Сон\bottom2.png", new PointF(150, 180));
        }

        public void BuildShoes1()
        {
            product.Add(@"Woman\Сон\shoes1.png", new PointF(100, 320));
            product.Add(@"Woman\Сон\shoes1.png", new PointF(200, 320));
        }

        public void BuildShoes2()
        {
            product.Add(@"Woman\Сон\shoes2.png", new PointF(100, 320));
            product.Add(@"Woman\Сон\shoes2.png", new PointF(200, 320));
        }

        public Product GetResult()
        {
            return product;
        }
    }
   // "Product" 

    class Product
    {
        List<Image> elements = new List<Image>();
        List<PointF> points = new List<PointF>();

        public void Add(string path, PointF point)
        {
            elements.Add(Image.FromFile(path));
            points.Add(point);
        }

        public void Show(Graphics g)
        {
            for (int i = 0; i < elements.Count; i++)
            {
                g.DrawImage(elements[i], points[i]);
            }
        }
    }
}
