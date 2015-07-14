using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using JetBrains.Annotations;

namespace WpfPointEditorExample
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public ObservableCollection<EditorPoint> Points { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}

	public class EditorPoint : INotifyPropertyChanged
	{
		private int _x;
		private int _y;

		public int X
		{
			get { return _x; }
			set
			{
				if (value == _x) return;
				_x = value;
				OnPropertyChanged("X");
			}
		}

		public int Y
		{
			get { return _y; }
			set
			{
				if (value == _y) return;
				_y = value;
				OnPropertyChanged("Y");
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
			var handler = PropertyChanged;
			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
