using System;

using UIKit;


namespace Fireworks
{
	public partial class ViewController : UIViewController
	{
       

        SimpleParticleGen fireworks;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			// Perform any additional setup after loading the view, typically from a nib.

            fireworks = new SimpleParticleGen(UIImage.FromFile("xamlogo.png"), View);


            btnStart.TouchUpInside += (object sender, EventArgs e) => {

                fireworks.Start();
            };       




		}

        partial void ButtonAbout_TouchUpInside(UIButton sender)
        {
			var aboutVC = (AboutViewController)this.Storyboard.InstantiateViewController("AboutViewController");

			this.PresentViewController(aboutVC, true, null);
        }



        partial void SliderSize_ValueChanged(UISlider sender)
        {
            fireworks.ScaleMax = (nfloat)sliderSize.Value;


        }


		partial void SwitchNight_ValueChanged(UISwitch sender)
		{
			if (switchNight.On)
				this.View.BackgroundColor = UIColor.FromRGB(25, 25, 112);
			else
                this.View.BackgroundColor = UIColor.White;
		}


		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

