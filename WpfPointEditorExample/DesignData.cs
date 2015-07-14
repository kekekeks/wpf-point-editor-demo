using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace WpfPointEditorExample
{
	class DesignData
	{
		public MainWindowViewModel MainWindowViewModel
		{
			get
			{
				return new MainWindowViewModel()
				{
					Points = new ObservableCollection<EditorPoint>()
					{
						new EditorPoint() {X = 50, Y = 70},
						new EditorPoint() {X = 120, Y = 130},
						new EditorPoint() {X = 70, Y = 102}
					}
				};
			}
		}
	}
}
