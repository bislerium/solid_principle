namespace solid_principle.liskov_substitution.Before
{
    public class Square : Rectangle
    {
        public override int Width
        {
            get { return base.Width; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height
        {
            get { return base.Height; }
            set
            {
                base.Width = value;
                base.Height = value;
            }
        }
    }
}
