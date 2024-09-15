

namespace Absolute.Layout
{
	public partial class MainPage : ContentPage
	{
		Label lbl;
		Label slider1Label;
		Label slider2Label;
		Label slider3Label;
		Slider slider1;
		Slider slider2;
		Slider slider3;
		Stepper stepper;
		BoxView boxView1;
		BoxView boxView2;
		BoxView boxView3;
		BoxView boxViewMain;
		AbsoluteLayout layout;
		Button random;

		public MainPage()
		{
			
			lbl = new Label
			{
				Text = "RGB Mudel",
				TextColor = Color.FromRgb(255, 0, 0),
				FontSize = 24,
				IsVisible = true
				
			};

			slider1 = new Slider
			{
				Minimum = 0,
				Maximum = 255,
				MinimumTrackColor = Color.FromRgb(0, 0, 0),
				MaximumTrackColor = Color.FromRgb(255, 0, 0),
				Value = 128
				
			};
			slider1.ValueChanged += red;
			slider1.ValueChanged += red_green_blue;

			slider2 = new Slider
			{
				Minimum = 0,
				Maximum = 255,
				MinimumTrackColor = Color.FromRgb(0, 0, 0),
				MaximumTrackColor = Color.FromRgb(0, 255, 0),
				Value = 128,
				

			};
			slider2.ValueChanged += green;
			slider2.ValueChanged += red_green_blue;

			slider3 = new Slider
			{
				Minimum = 0,
				Maximum = 255,
				MinimumTrackColor = Color.FromRgb(0, 0, 0),
				MaximumTrackColor = Color.FromRgb(0, 0, 255),
				Value = 128,
			};
			slider3.ValueChanged += blue;
			slider3.ValueChanged += red_green_blue;

			stepper = new Stepper
			{
				Minimum = 0,
				Maximum = 100,
				Increment = 5,
			};
			stepper.ValueChanged += corner_radius;

			boxView1 = new BoxView
			{
				BackgroundColor = Color.FromRgb(255, 0, 0),
				CornerRadius = 25
				
			};
			

			boxView2 = new BoxView
			{
				BackgroundColor = Color.FromRgb(0, 255, 0),
				CornerRadius = 25

			};

			boxView3 = new BoxView
			{
				BackgroundColor = Color.FromRgb(0, 0, 255),
				CornerRadius = 25

			};

			boxViewMain = new BoxView
			{
				BackgroundColor = Color.FromRgb(255, 0, 0),
				CornerRadius = 25

			};

			random = new Button
			{
				Text = "Random",
			};
			
			TapGestureRecognizer aboba = new TapGestureRecognizer();
			aboba.Tapped += Random_Color;
			aboba.Tapped += button_color;
			random.GestureRecognizers.Add(aboba);

			slider1Label = new Label
			{
				Text = slider1.Value.ToString(),
				TextColor = Color.FromRgb(128, 0, 0),


			};

			slider2Label = new Label
			{
				Text = slider2.Value.ToString(),
				TextColor = Color.FromRgb(0, 128, 0),
			};

			slider3Label = new Label
			{
				Text = slider3.Value.ToString(),
				TextColor = Color.FromRgb(0, 0, 128),
			};





			layout = new AbsoluteLayout
			{
				Children = { lbl, slider1, slider2, slider3, boxView1, boxView2, boxView3, boxViewMain, stepper, random, slider2Label, slider1Label, slider3Label }
			};

			AbsoluteLayout.SetLayoutBounds(lbl, new Rect(125, 25, 300, 50));
			AbsoluteLayout.SetLayoutBounds(slider1, new Rect(10, 100, 300, 50));
			AbsoluteLayout.SetLayoutBounds(slider2, new Rect(10, 130, 300, 50));
			AbsoluteLayout.SetLayoutBounds(slider3, new Rect(10, 160, 300, 50));
			AbsoluteLayout.SetLayoutBounds(stepper, new Rect(10, 190, 300, 50));
			AbsoluteLayout.SetLayoutBounds(boxView1, new Rect(10, 250, 100, 100));
			AbsoluteLayout.SetLayoutBounds(boxView2, new Rect(120, 250, 100, 100));
			AbsoluteLayout.SetLayoutBounds(boxView3, new Rect(230, 250, 100, 100));
			AbsoluteLayout.SetLayoutBounds(boxViewMain, new Rect(10, 450, 300, 300));
			AbsoluteLayout.SetLayoutBounds(random, new Rect(230, 190, 50, 50));
			AbsoluteLayout.SetLayoutBounds(slider1Label, new Rect(300, 100, 50, 50));
			AbsoluteLayout.SetLayoutBounds(slider2Label, new Rect(300, 130, 50, 50));
			AbsoluteLayout.SetLayoutBounds(slider3Label, new Rect(300, 160, 50, 50));

			Content = layout;

		}

		public void red(object sender, ValueChangedEventArgs e)
		{
			int intValue = (int)e.NewValue;
			boxView1.BackgroundColor = Color.FromRgb(intValue, 0, 0);
			slider1Label.Text = intValue.ToString();
			slider1Label.TextColor = Color.FromRgb(intValue, 0, 0);
		}

		public void green(object sender, ValueChangedEventArgs e)
		{
			int intValue = (int)e.NewValue;
			boxView2.BackgroundColor = Color.FromRgb(0, intValue, 0);
			slider2Label.Text = intValue.ToString();
			slider2Label.TextColor = Color.FromRgb(0, intValue, 0);
		}

		public void blue(object sender, ValueChangedEventArgs e)
		{
			int intValue = (int)e.NewValue;
			boxView3.BackgroundColor = Color.FromRgb(0, 0, intValue);
			slider3Label.Text = intValue.ToString();
			slider3Label.TextColor = Color.FromRgb(0, 0, intValue);
		}

		public void red_green_blue(object sender, ValueChangedEventArgs e)
		{
			int redValue = (int)slider1.Value;
			int greenValue = (int)slider2.Value;
			int blueValue = (int)slider3.Value;
			lbl.TextColor = Color.FromRgb(redValue, greenValue, blueValue);
			boxViewMain.BackgroundColor = Color.FromRgb(redValue, greenValue, blueValue);

		}

		public void corner_radius(object sender, ValueChangedEventArgs e)
		{
			int intValue = (int)e.NewValue;
			boxViewMain.CornerRadius = intValue;
			boxView1.CornerRadius = intValue;
			boxView2.CornerRadius = intValue;
			boxView3.CornerRadius = intValue;


		}

		public async void Random_Color(object sender, EventArgs e)
		{
			Random random = new Random();
			int random_value = random.Next(0, 255);
			int random_value2 = random.Next(0, 255);
			int random_value3 = random.Next(0, 255);
			slider1.Value = random_value;
			slider2.Value = random_value2;
			slider3.Value = random_value3;

		}

		public void button_color(object sender, EventArgs e)
		{
			int redValue = (int)slider1.Value;
			int greenValue = (int)slider2.Value;
			int blueValue = (int)slider3.Value;
			random.BackgroundColor = Color.FromRgb(redValue, greenValue, blueValue);
			
		}

		










	}

	
	
	

}
