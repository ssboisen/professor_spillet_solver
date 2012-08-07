using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

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
            solver.PrintSolution(solutions.First());
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
            foreach (var checker in _checkers)
            {
                foreach (var board in checker.Sides.Select(t => new ProfessorChecker[16]))
                {
                    board[0] = checker;

                    var solutions = BuildSolutionRecursively(board, 0).ToList();

                    foreach (var solution in solutions)
                    {
                        yield return solution;
                    }

                    checker.TurnRight();
                }
            }

            Console.WriteLine("{0} possible solutions tried", count);
        }

        private int count;
        private IEnumerable<ProfessorChecker[]> BuildSolutionRecursively(ProfessorChecker[] board, int solutionIndex)
        {
            var nextIndex = solutionIndex + 1;

            var matchingCheckers = FindMatchingChecker(board, solutionIndex).ToList();

            foreach (var nextChecker in matchingCheckers)
            {
                for (int i = nextIndex; i < 16; i++)
                {
                    board[i] = null;
                }

                board[nextIndex] = nextChecker;

                if (nextIndex == 15)
                {
                    yield return board.Select(pc => pc.Clone()).ToArray();
                }

                if (nextIndex < 15)
                {
                    foreach (var solution in BuildSolutionRecursively(board, nextIndex))
                    {
                        yield return solution;
                    }

                }
            }

            count++;
        }

        private ProfessorChecker[] Clone(ProfessorChecker[] solution)
        {
            return solution.Select(pc => pc != null ? pc.Clone() : null).ToArray();
        }

        private bool IsSolutionValid(ProfessorChecker[] solution)
        {
            var nonNullSolution = solution.Where(x => x != null).ToArray();
            bool retVal = true;
            for (int i = 1; i < nonNullSolution.Length; i++)
            {
                var current = nonNullSolution[i];
                if (i >= 1 && i <= 3) //first row
                {
                    var leftChecker = nonNullSolution[i - 1];

                    if (!(leftChecker.Right.Color == current.Left.Color &&
                        leftChecker.Right.BodyPart != current.Left.BodyPart))
                    {
                        retVal = false;
                    }
                }

                else if (i == 4) //first column, second row
                {
                    var topChecker = nonNullSolution[0];

                    if (!(topChecker.Bottom.Color == current.Top.Color
                        && topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }

                else if (i > 4 && i <= 7) //second row, column 2-4
                {
                    var leftChecker = nonNullSolution[i - 1];
                    var topChecker = nonNullSolution[i % 4];

                    if (!(leftChecker.Right.Color == current.Left.Color &&
                        leftChecker.Right.BodyPart != current.Left.BodyPart &&
                        topChecker.Bottom.Color == current.Top.Color &&
                        topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }


                else if (i == 8) //first column, third row
                {
                    var topChecker = nonNullSolution[4];

                    if (!(topChecker.Bottom.Color == current.Top.Color
                        && topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }

                if (i > 8 && i <= 11) //third row, column 2-4
                {
                    var leftChecker = nonNullSolution[i - 1];
                    var topChecker = nonNullSolution[i - 4];

                    if (!(leftChecker.Right.Color == current.Left.Color &&
                        leftChecker.Right.BodyPart != current.Left.BodyPart &&
                        topChecker.Bottom.Color == current.Top.Color &&
                        topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }

                else if (i == 12) //first column, fourth row
                {
                    var topChecker = nonNullSolution[8];

                    if (!(topChecker.Bottom.Color == current.Top.Color
                        && topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }

                else if (i > 12 && i <= 15) //third row, column 2-4
                {
                    var leftChecker = nonNullSolution[i - 1];
                    var topChecker = nonNullSolution[i - 4];

                    if (!(leftChecker.Right.Color == current.Left.Color &&
                        leftChecker.Right.BodyPart != current.Left.BodyPart &&
                        topChecker.Bottom.Color == current.Top.Color &&
                        topChecker.Bottom.BodyPart != current.Top.BodyPart))
                    {
                        retVal = false;
                    }
                }

                if (!retVal)
                {
                    Console.WriteLine("Invalid: " + current);
                    break;
                }
            }

            return retVal;
        }
        public void PrintSolution(ProfessorChecker[] solution)
        {
            Console.WriteLine("------------- SOLUTION START --------------");
            for (int i = 0; i < solution.Length; i++)
            {
                var pc = solution[i];
                Console.WriteLine(i);
                Console.WriteLine(pc);
            }

            Console.WriteLine("------------- SOLUTION END --------------");
        }

        private IEnumerable<ProfessorChecker> FindMatchingChecker(ProfessorChecker[] solution, int solutionIndex)
        {
            var unused = _checkers.Except(solution).ToList();

            var thisIndex = solutionIndex + 1;

            foreach (var unusedProfessorChecker in unused)
            {
                for (int i = 0; i < unusedProfessorChecker.Sides.Length; i++)
                {
                    if (thisIndex >= 1 && thisIndex <= 3) //first row
                    {
                        var leftChecker = solution[solutionIndex];

                        if (leftChecker.Right.Color == unusedProfessorChecker.Left.Color &&
                            leftChecker.Right.BodyPart != unusedProfessorChecker.Left.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else if (thisIndex == 4) //first column, second row
                    {
                        var topChecker = solution[0];

                        if (topChecker.Bottom.Color == unusedProfessorChecker.Top.Color
                            && topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else if (thisIndex >= 5 && thisIndex <= 7) //second row, column 2-4
                    {
                        var leftChecker = solution[thisIndex - 1];
                        var topChecker = solution[thisIndex % 4];

                        if (leftChecker.Right.Color == unusedProfessorChecker.Left.Color &&
                            leftChecker.Right.BodyPart != unusedProfessorChecker.Left.BodyPart &&
                            topChecker.Bottom.Color == unusedProfessorChecker.Top.Color &&
                            topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }


                    else if (thisIndex == 8) //first column, third row
                    {
                        var topChecker = solution[4];

                        if (topChecker.Bottom.Color == unusedProfessorChecker.Top.Color
                            && topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else if (thisIndex >= 9 && thisIndex <= 11) //third row, column 2-4
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

                    else if (thisIndex == 12) //first column, fourth row
                    {
                        var topChecker = solution[8];

                        if (topChecker.Bottom.Color == unusedProfessorChecker.Top.Color
                            && topChecker.Bottom.BodyPart != unusedProfessorChecker.Top.BodyPart)
                        {
                            yield return unusedProfessorChecker.Clone();
                        }
                    }

                    else if (thisIndex >= 13 && thisIndex <= 15) //third row, column 2-4
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
