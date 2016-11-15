namespace TriangleThing.Objects
{
  public class Triangle
  {
    private int _side1;
    private int _side2;
    private int _side3;

    public Triangle (int side1, int side2, int side3) {
      _side1 = side1;
      _side2 = side2;
      _side3 = side3;
    }

    public string TypeOfTriangle() {
      if ( (_side1 + _side2) <= _side3 || (_side2 + _side3) <= _side1 || (_side1 + _side3) <= _side2 )
      {
      return "not a triangle";
      }
      else
      {
        if (_side1 == _side2 && _side1 == _side3)
        {
          return "equilateral";
        }
        else if (_side1 == _side2 || _side1 == _side3 || _side2 == _side3)
        {
          return "isosceles";
        }
        else
        {
          return "scalene";
        }
      }
    }
  }
}
