using System;

namespace MetricConveter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var value = decimal.Parse (Console.ReadLine ());
			var firstUnits = Console.ReadLine ();
			var secondUnits = Console.ReadLine ();
			var meters = 1.0m; //m
			var milimetes = meters / 1000.0m;//mm
			var  centimeters = meters / 100.0m;//cm
			var kilometers = meters * 1000.0m;//km
			var miles = meters * 1609.344m;//mi
			var inches = meters / 2.54m;//in
			var yards = meters * 1.0936133m;//yd
			var feet = meters * 3.2808399m;//ft
			switch (firstUnits) 
			{
				case "m":
					{
						switch ( secondUnits) 
						{
							case "mm":
								{
									value *= 1000m;	

								}
								break;
							case "cm":
								{
									value *= 100m;	

								}
								break;
							case "km":
								{
									value /= 1000m;	

								}
								break;
							case "mi":
								{
									value *= 0.000621371192m ;	

								}
								break;
							case "in":
								{
									value *= 39.3700787m ;	

								}
								break;							
							case "yd":
								{
									value *= 1.0936133m ;	

								}
								break;		
							case "ft":
								{
									value *= 3.2808399m ;	

								}
								break;	
							default:break;
						}		
					}
					break;
				case "mm":
					{
						switch ( secondUnits) 
						{
						case "m":
							{
								value /=1000m;	
							}
							break;
						case "cm":
							{
								value /= 10m;	
							}
							break;
						case "km":
							{
								value /= 1000000m;	
							}
							break;
						case "mi":
							{
								value /= 1000m;
								value *= 0.000621371192m ;	
							}
							break;
						case "in":
							{
								value /= 1000m;
								value *= 39.3700787m ;	
							}
							break;							
						case "yd":
							{
								value /= 1000m;
								value *= 1.0936133m ;	
							}
							break;		
						case "ft":
							{
								value /= 1000m;
								value *= 3.2808399m ;	
							}
							break;	
						default:break;
						}		
					}
					break;
				case "cm":
						{
							switch ( secondUnits) 
							{
							case "m":
								{
									value /=100m;	
								}
								break;
							case "mm":
								{
									value *= 10m;	
								}
								break;
							case "km":
								{
									value /= 100000m;	
								}
								break;
							case "mi":
								{
									value /=100m;	
									value *= 0.000621371192m ;	
								}
								break;
							case "in":
								{
									value /= 100m;
									value *= 39.3700787m ;	
								}
								break;							
							case "yd":
								{
									value /= 100m;
									value *= 1.0936133m ;	
								}
								break;		
							case "ft":
								{
									value /= 100m;
									value *= 3.2808399m ;	
								}
								break;	
							default:break;
							}		
						}
						break;
					case "km":
						{
							switch ( secondUnits) 
							{
							case "m":
								{
									value *=1000m;	
								}
								break;
							case "mm":
								{
									value *= 1000000m;	
								}
								break;
							case "cm":
								{
									value *= 100000m;	
								}
								break;
							case "mi":
								{
									value *=1000m;	
									value *= 0.000621371192m ;	
								}
								break;
							case "in":
								{
									value *=1000m;	
									value *= 39.3700787m ;	
								}
								break;							
							case "yd":
								{
									value *=1000m;	
									value *= 1.0936133m ;	
								}
								break;		
							case "ft":
								{
									value *=1000m;	
									value *= 3.2808399m ;	
								}
								break;	
							default:break;
							}		
						}
						break;
				case "mi":
					{
						switch ( secondUnits) 
						{
						case "m":
							{
								value *=1609.344m;	
							}
							break;
						case "mm":
							{

								value *=1609.344m;	
								value *= 1000m;	
							}
							break;
						case "cm":
							{

								value *=1609.344m;	
								value *= 100m;	
							}
							break;
						case "km":
							{
								value *=1609.344m;	
								value /= 1000m ;	
							}
							break;
						case "in":
							{
								value *=1609.344m;	
								value *= 39.3700787m ;	
							}
							break;							
						case "yd":
							{
								value *=1609.344m;	
								value *= 1.0936133m ;	
							}
							break;		
						case "ft":
							{
								value *=1609.344m;	
								value *= 3.2808399m;	
							}
							break;	
						default:break;
						}		
					}
					break;
				case "in":
					{
						switch ( secondUnits) 
						{
						case "m":
							{
								value /= 39.3700787m ;	
							}
							break;
						case "mm":
							{

								value /= 39.3700787m ;	
								value *= 1000m;	
							}
							break;
						case "cm":
							{

								value /= 39.3700787m  ;
								value *= 100m;	
							}
							break;
						case "km":
							{
								value /= 39.3700787m  ;
								value /= 1000m ;	
							}
							break;
						case "mi":
							{
								value /= 39.3700787m  ;
								value /=1609.344m;	
							}
							break;							
						case "yd":
							{
								value /= 39.3700787m ;	
								value *= 1.0936133m ;	
							}
							break;		
						case "ft":
							{
								value /= 39.3700787m ;	
								value *= 3.2808399m ;	
							}
							break;	
						default:break;
						}		
					}
					break;
					
				case "yd":
					{
						switch ( secondUnits) 
						{
						case "m":
							{
								value /= 1.0936133m ;							
							}
							break;
						case "mm":
							{

								value /= 1.0936133m ;							
								value *= 1000m;	
							}
							break;
						case "cm":
							{

								value /= 1.0936133m ;							
								value *= 100m;	
							}
							break;
						case "km":
							{
								value /= 1.0936133m ;							
								value /= 1000m ;	
							}
							break;
						case "mi":
							{
								value /= 1.0936133m ;							
								value /=1609.344m;	
							}
							break;							
						case "in":
							{
								value /= 1.0936133m ;							
								value *= 39.3700787m ;	
								
							}
							break;		
						case "ft":
							{
								value /= 1.0936133m ;							
								value *= 3.2808399m ;	
							}
							break;	
						default:break;
						}		
					}
					break;
				case "ft":
				{
					switch ( secondUnits) 
					{
					case "m":
						{
							value /= 3.2808399m ;	
						}
						break;
					case "mm":
						{

							value /= 3.2808399m ;	
							value *= 1000m;	
						}
						break;
					case "cm":
						{

							value /= 3.2808399m ;	
							value *= 100m;	
						}
						break;
					case "km":
						{
							value /= 3.2808399m ;	
							value /= 1000m ;	
						}
						break;
					case "mi":
						{
							value /= 3.2808399m ;	
							value /=1609.344m;	
						}
						break;							
					case "in":
						{
							value /= 3.2808399m ;	
							value *= 39.3700787m ;	

						}
						break;		
					case "yd":
						{
							value /= 3.2808399m ;	
							value *= 1.0936133m ;							

						}
						break;	
					default:break;
					}		
				}
				break;
			default:break;
			}
			Console.WriteLine ("{0:############0.##############}", value);
		}
	}
}
