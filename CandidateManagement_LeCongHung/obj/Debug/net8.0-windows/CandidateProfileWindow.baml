   M S B A M L   `   `   `  ����Y  UCandidateManagement_LeCongHung, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:CandidateManagement_LeCongHungCandidateManagement_LeCongHung  5   	   ;    5CandidateManagement_LeCongHung.CandidateProfileWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   >local,clr-namespace:CandidateManagement_LeCongHung     5   	     � Title$  CandidateProfileWindow��5   	   $	��583��6(   $	��805��65    � WindowStartupLocation$ CenterScreen=�6A    � WindowStyle$
 None=�6f   .��5	      � -   5        $��	0,0,10,17q�5	      .+�5
   
   �� $"��CANDIDATE PROFILE MANAGEMENT��6   $��Center=�67   $��0,10,0,0q�6T   $	��Top=�6f   $��32(�6~   $
��Bold"�6�   �� 5   
   $��Candidate ID��6   $
��Left=�6'   $��	10,68,0,0q�6B   $	��Top=�6U   $��16(�6m   �� 5   
   $��FullName��6   $
��Left=�6#   $��
10,104,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��Birthday��6   $
��Left=�6#   $��
10,176,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��Description��6   $
��Left=�6&   $��414,104,0,0q�6A   $	��Top=�6V   $��16(�6n   �� 5   
   $��ImageURL��6   $
��Left=�6#   $��
10,140,0,0q�6>   $	��Top=�6R   $��16(�6j   �� 5   
   $��JobPosting ID��6   $
��Left=�6(   $��
414,68,0,0q�6C   $	��Top=�6W   $��16(�6o   �� 5   
   -   5         ��Name$ txtCandidateID��5      $
��Left=�6*   $��
138,72,0,0q�6E    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��223��6�   $��16(�6�   �� 5   
   -   5        $ txtFullName��5      $
��Left=�6'   $��138,108,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��223��6�   $��16(�6�   �� 5   
   -   5        $ txtImageUrl��5      $
��Left=�6'   $��138,144,0,0q�6B   $
 Wrap=�6W   $	��Top=�6k   $	��223��6�   $��16(�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ txtBirthday��5      $
��Left=�6*   $��138,180,0,0q�6E   $	��Top=�6Z   $	��223��6r   �� 5   
   -   5         ��Name$ 	cmbPostID��5      $
��Left=�6&   $��
534,70,0,0q�6A   $	��Top=�6U   $	��241��6m   $��16(�6y   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtgCandidateProfile��5      $��10,222,20,89q�6[   6q   �� 5   
   -   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��
10,498,0,0q�6J   $	��Top=�6^   $	��150��6v   $��40��6�   $��16(�6�   $
��Bold"�6�   ���	#FF80FF536�   �� 5   
   -	   5        $ btnClose��5      $��Close��6#   $
��Left=�63   $��625,498,0,0q�6N   $	��Top=�6c   $	��150��6{   $��40��6�   $��16(�6�   $
��Bold"�6�   ���	#FFB7B7B76�   �� 5   
   -
   5        $ 	btnUpdate��5      $��Update��6$   $
��Left=�65   $��222,498,0,0q�6P   $	��Top=�6e   $	��150��6}   $��40��6�   $��16(�6�   $
��Bold"�6�   ���	#FF9BEEF96�   �� 5   
   -   5        $ 	btnDelete��5      $��Delete��6$   $
��Left=�65   $��430,498,0,0q�6P   $	��Top=�6e   $	��150��6}   $��40��6�   $��16(�6�   $
��Bold"�6�   ���	#FFF398896�   �� 5   
   -   5        $ txtDescription��5      $
��Left=�6*   $��414,144,0,0q�6E   $
 Wrap=�6Z   $	��Top=�6n   $	��361��6�   $��60��6�   5      5      