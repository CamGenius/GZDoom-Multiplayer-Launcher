   M S B A M L   `   `   `  ���� V  RGZdoom Multiplayer Launcher, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:GZdoom_Multiplayer_LauncherGZdoom_Multiplayer_Launcher  ,    &GZdoom_Multiplayer_Launcher.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ;local)clr-namespace:GZdoom_Multiplayer_Launcher       � Title$!  GZDoom Multiplayer Launcher��$	��300��$	��800�� � 
ResizeMode$ CanMinimize=� � Icon$% GZDoom Multiplayer Launcher.ico��.��� $	��270��$	��Top=�.+�	� -    	�Name$
 Host��$
��Host��$
��Left=�$��	10,10,0,0q�$	��Top=� 	� 	GroupName$ 
HostOrJoin��	� -   $
 Join��$
��Join��$
��Left=�$��
530,10,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.55,-1.067&�$ 
HostOrJoin��� -    �Name$ hGrid��$
��Left=�$	��175��$��	10,30,0,0q�$	��Top=�$	��515��{�.  .+��� -    ��Name$ PlayerCount��$
��Left=�$��	10,41,0,0q�$	��Top=�$ 0.5,0.5&�$	��183�� � Maximum$ 8Q�	 � Minimum$	 1Q�
 � Value$
 2Q� �� IsSnapToTickEnabled . �� $'��!Player Count (including the host)��$
��Left=�$��	10,10,0,0q�$	��Top=��� -    ��Name$ PlayerCountLabel��$��2��$
��Left=�$��
189,36,0,0q�$	��Top=��� $��	Game Type��$
��Left=�$��
210,10,0,0q�$	��Top=��� -    ��Name$ Gametype��$
��Left=�$��
210,37,0,0q�$	��Top=�$	��145�� �� SelectedIndex$ 0��.@��� -    ��Name$ Co_op�� � ToolTip$ Cooperative gameplay��.��Co-op�� -   $ 
Deathmatch��$# Weapons drop when player dies��.��
Deathmatch�� -	   $ Alternate_Deathmatch��$+ %Weapons respawn after being picked up��.��Alternate Deathmatch�� $��Difficulty Level��$
��Left=�$��
360,10,0,0q�$	��Top=��� -
   $ 
Difficulty��$
��Left=�$��360,36,-5,0q�$	��Top=�$	��140��$ 2��.@��� -   $ D1��.��I'm too young to die�� -   $ D2��.��Hey, not too rough�� -   $ D3��.��Hurt me plenty�� -   $ D4��.��Ultra-Violence�� -   $ D5��.��
Nightmare!�� $��Episode��$
��Left=�$��	10,64,0,0q�$	��Top=��� -   $ Episode��$
��Left=�$��	10,90,0,0q�$	��Top=�$	��155��$ 0��.@��� -   $ E1��.��Knee-Deep in the Dead�� -   $ E2��$ No Shareware Version��.��The Shores of Hell�� -   $ E3��$ No Shareware Version��.��	Inferno�� -   $ E4��$/ )Ultimate Doom ONLY & No Shareware Version��.��Thy Flesh Consumed�� $	��Map��$
��Left=�$��
170,64,0,0q�$	��Top=��� -   $	 Map��$
��Left=�$��
170,90,0,0q�$	��Top=�$	��329��$ 0��.@��� -   $ M1��.��Hangar�� -   $ M2��.��Nuclear Plant�� -   $ M3��.��(&Toxin Refinery - Secret Level Entrance�� -   $ M4��.��Command Control�� -   $ M5��.��
Phobos Lab�� -   $ M6��.��Central Processing�� -   $ M7��.��Computer Station�� -   $ M8��.��Phobos Anomaly - Boss Level�� -   $ M9��.��Military Base - Secret Level�� -   $	 M10��$y�	Collapsed=�.��Deimos Anomaly�� -    $	 M11��$y�	Collapsed=�.��Contaiment Area�� -!   $	 M12��$y�	Collapsed=�.��
Refinery�� -"   $	 M13��$y�	Collapsed=�.��
Deimos Lab�� -#   $	 M14��$y�	Collapsed=�.��(&Command Center - Secret Level Entrance�� -$   $	 M15��$y�	Collapsed=�.��Halls of the Damned�� -%   $	 M16��$y�	Collapsed=�.��Spawning Vats�� -&   $	 M17��$y�	Collapsed=�.��Tower of Babel - Boss Level�� -'   $	 M18��$y�	Collapsed=�.��$"Fortress of Mystery - Secret Level�� -(   $	 M19��$y�	Collapsed=�.��	Hell Keep�� -)   $	 M20��$y�	Collapsed=�.��Slough of Despair�� -*   $	 M21��$y�	Collapsed=�.��Pandemonium�� -+   $	 M22��$y�	Collapsed=�.��House of Pain�� -,   $	 M23��$y�	Collapsed=�.��Unholy Cathedral�� --   $	 M24��$y�	Collapsed=�.��$"Mt. Erebus - Secret Level Entrance�� -.   $	 M25��$y�	Collapsed=�.��Limbo�� -/   $	 M26��$y�	Collapsed=�.��Dis - Boss Level�� -0   $	 M27��$y�	Collapsed=�.��Warrens - Secret Level�� -1   $	 M28��$y�	Collapsed=�.��Hell Beneath�� -2   $	 M29��$y�	Collapsed=�.��(&Perfect Hatred - Secret Level Entrance�� -3   $	 M30��$y�	Collapsed=�.��Sever the Wicked�� -4   $	 M31��$y�	Collapsed=�.��Unruly Evil�� -5   $	 M32��$y�	Collapsed=�.��They Will Repent�� -6   $	 M33��$y�	Collapsed=�.��Against Thee Wickedly�� -7   $	 M34��$y�	Collapsed=�.��And Hell Followed�� -8   $	 M35��$y�	Collapsed=�.��Unto the Cruel - Boss Level�� -9   $	 M36��$y�	Collapsed=�.��Fear - Secret Level�� $%��Broadcast to the Master Server?��$
��Left=�$��
10,117,0,0q�$	��Top=�	� -:   $	 pNo��$��No��$
��Left=�$��
40,148,0,0q�$	��Top=�$ Private�� d� 	IsChecked$
 TrueY�	� -;   $
 pYes��$	��Yes��$
��Left=�$��109,148,0,0q�$	��Top=�$ Private���� $
��Port��$
��Left=�$��193,117,0,0q�$	��Top=��� -<    ��Name$ HPort��$
��Left=�$��23��$��193,143,0,0q� �� TextWrapping$
 Wrap=�$��Center=�$	��Top=�$��50��$
��5029���� $��Additional Commands��$
��Left=�$��248,117,0,0q�$	��Top=��� -=   $	 HAC��$
��Left=�$��23��$��248,143,0,0q�$
 Wrap=�$��Center=�$	��Top=�$	��252��� ->   $ cGrid��$
��Left=�$	��175��$��
530,30,0,0q�$	��Top=�$	��250��{�.  .+��� $��
IP Address��$
��Left=�$��	10,10,0,0q�$	��Top=��� -?   $ IP��$
��Left=�$��23��$��	10,36,0,0q�$
 Wrap=�$��Center=�$	��Top=�$	��232��$��	127.0.0.1���� $
��Port��$
��Left=�$��	10,64,0,0q�$	��Top=��� -@   $ CPort��$
��Left=�$��23��$��	10,90,0,0q�$
 Wrap=�$��Center=�$	��Top=�$��50��$
��5029���� $��Additional Commands��$
��Left=�$��
10,118,0,0q�$	��Top=��� -A   $	 CAC��$
��Left=�$��23��$��
10,144,0,0q�$
 Wrap=�$��Center=�$	��Top=�$	��232���� -B    ��Name$ Start��$��Start��$
��Left=�$��
10,210,0,0q�$	��Top=�$	��770��$��50��$��24(�{�.  