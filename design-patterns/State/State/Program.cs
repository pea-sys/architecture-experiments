namespace State
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  
        ///  State�p�^�[���E�E�E��Ԃ��N���X�Ƃ��ĊǗ����܂�
        ///  
        ///  �l�I�ɂ̓f�o�C�X�h���C�o�̊J���Ŏg�p���Ă��܂�
        ///  �e�X�g�����₷�����A�e�X�g�R����������ɂ���
        ///  �@�\��������Α������AState�p�^�[���̊挒���͖𗧂Ɗ����Ă܂�
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new SafeForm());
        }
    }
}