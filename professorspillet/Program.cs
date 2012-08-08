using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace professorspillet
{
    class Program
    {

        static void Main(string[] args)
        {
            var solver = new ProfessorGameSolver(new ProfessorChecker[]
                                                    {
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),

                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),

                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),


                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),

                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),

                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue)),

                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Blue),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Green)),
                                                                             
                                                        new ProfessorChecker(new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Purple),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Green),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Top, Color.Brown),
                                                                             new ProfessorChecker.ProfessorCheckerSideConfig(BodyPart.Bottom, Color.Brown)),
                                                    });
            var sw = Stopwatch.StartNew();
            var solutions = solver.Solve().ToList();
            Console.WriteLine("{0} solutions found", solutions.Count);
            Console.WriteLine(sw.Elapsed);
            Console.ReadKey();
        }
    }

    public class ProfessorGameSolver
    {
        private readonly ProfessorChecker[] _checkers;

        public ProfessorGameSolver(ProfessorChecker[] checkers)
        {
            if (checkers.Length != 16)
                throw new ArgumentOutOfRangeException("checkers");

            _checkers = checkers;
        }

        public IEnumerable<ProfessorChecker[]> Solve()
        {
            var bag = new ConcurrentBag<ProfessorChecker[]>();
            _checkers.AsParallel().ForAll(checker =>
                                              {
                                                  var checkers = _checkers.Select(c => c.Clone()).ToArray();
                                                  for (int i = 0; i < 4; i++)
                                                  {
                                                      var board = new ProfessorChecker[16];
                                                      board[0] = checker;

                                                      var solutions = BuildSolutionRecursively(board, 0, checkers).ToList();

                                                      foreach (var solution in solutions)
                                                      {
                                                          bag.Add(solution);
                                                      }

                                                      checker.TurnRight();
                                                  }
                                              });
            return bag;
        }

        private object obj = new object();
        private IEnumerable<ProfessorChecker[]> BuildSolutionRecursively(ProfessorChecker[] board, int solutionIndex, ProfessorChecker[] checkers)
        {
            var nextIndex = solutionIndex + 1;
            var matchingCheckers = FindMatchingChecker(board, solutionIndex, checkers).ToList();

            foreach (var nextChecker in matchingCheckers)
            {
                board[nextIndex] = nextChecker;

                if (nextIndex == 15)
                {
                    yield return board.Select(pc => pc.Clone()).ToArray();
                }

                if (nextIndex < 15)
                {
                    foreach (var solution in BuildSolutionRecursively(board, nextIndex, checkers))
                    {
                        yield return solution;
                    }
                }

                board[nextIndex] = null;
            }
        }

        private IEnumerable<ProfessorChecker> FindMatchingChecker(ProfessorChecker[] solution, int solutionIndex, ProfessorChecker[] checkers)
        {
            var unused = checkers.Except(solution).ToList();

            var thisIndex = solutionIndex + 1;

            foreach (var unusedProfessorChecker in unused)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (thisIndex < 4) //first row
                    {
                        var leftChecker = solution[solutionIndex];

                        if (leftChecker.Right.Color == unusedProfessorChecker.Left.Color &&
                            leftChecker.Right.BodyPart != unusedProfessorChecker.Left.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else if (thisIndex % 4 == 0) //first column, in any other row
                    {
                        var topChecker = solution[thisIndex - 4];

                        if (topChecker.Bottom.Color == unusedProfessorChecker.Top.Color
                            && topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else //2nd-4th column in 2nd-4th row
                    {
                        var leftChecker = solution[thisIndex - 1];
                        var topChecker = solution[thisIndex - 4];

                        if (leftChecker.Right.Color == unusedProfessorChecker.Left.Color &&
                            leftChecker.Right.BodyPart != unusedProfessorChecker.Left.BodyPart &&
                            topChecker.Bottom.Color == unusedProfessorChecker.Top.Color &&
                            topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    unusedProfessorChecker.TurnRight();
                }
            }
        }

    }

    public enum BodyPart { Top, Bottom }
    public enum Color { Brown, Green, Purple, Blue }


    public class ProfessorChecker
    {
        private readonly Guid _id;

        public class ProfessorCheckerSideConfig
        {
            private readonly BodyPart _bodyPart;
            public BodyPart BodyPart
            {
                get { return _bodyPart; }

            }

            private readonly Color _color;
            public Color Color
            {
                get { return _color; }

            }

            public ProfessorCheckerSideConfig(BodyPart bodyPart, Color color)
            {
                _bodyPart = bodyPart;
                _color = color;
            }

            public override string ToString()
            {
                return BodyPart + "-" + Color;
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                if (obj.GetType() != typeof(ProfessorCheckerSideConfig)) return false;
                return Equals((ProfessorCheckerSideConfig)obj);
            }

            public bool Equals(ProfessorCheckerSideConfig other)
            {
                if (ReferenceEquals(null, other)) return false;
                if (ReferenceEquals(this, other)) return true;
                return Equals(other._bodyPart, _bodyPart) && Equals(other._color, _color);
            }

            public ProfessorCheckerSideConfig Clone()
            {
                return new ProfessorCheckerSideConfig(BodyPart, Color);
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    return (_bodyPart.GetHashCode() * 397) ^ _color.GetHashCode();
                }
            }
        }

        private readonly ProfessorCheckerSideConfig[] _sides;
        private int _topIndex;
        public ProfessorChecker(ProfessorCheckerSideConfig top, ProfessorCheckerSideConfig right, ProfessorCheckerSideConfig bottom, ProfessorCheckerSideConfig left)
        {
            _sides = new[] { top, right, bottom, left };
            _id = Guid.NewGuid();
        }

        public ProfessorChecker(ProfessorCheckerSideConfig top, ProfessorCheckerSideConfig right, ProfessorCheckerSideConfig bottom, ProfessorCheckerSideConfig left, Guid id)
        {
            _id = id;
            _sides = new[] { top, right, bottom, left };
        }

        public ProfessorCheckerSideConfig[] Sides
        {
            get { return _sides; }
        }

        public ProfessorCheckerSideConfig Top
        {
            get { return Sides[_topIndex]; }
        }

        public ProfessorCheckerSideConfig Right
        {
            get { return Sides[(_topIndex + 1) % 4]; }
        }

        public ProfessorCheckerSideConfig Bottom
        {
            get { return Sides[(_topIndex + 2) % 4]; }
        }

        public ProfessorCheckerSideConfig Left
        {
            get { return Sides[(_topIndex + 3) % 4]; }
        }

        public void TurnRight()
        {
            _topIndex = ((_topIndex + 1) % 4);
        }

        public void Reset()
        {
            _topIndex = 0;
        }

        public override string ToString()
        {
            return "Left: " + Left + ";Top: " + Top + ";Right: " + Right + ";Bottom: " + Bottom;
        }

        public ProfessorChecker Clone()
        {
            return new ProfessorChecker(Top.Clone(), Right.Clone(), Bottom.Clone(), Left.Clone(), _id);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != typeof(ProfessorChecker)) return false;
            return Equals((ProfessorChecker)obj);
        }

        public bool Equals(ProfessorChecker other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return other._id.Equals(_id);
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode();
        }
    }
}
