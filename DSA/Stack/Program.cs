int[] arr = new int[] { 36, 6, 7, 45, 3, 34 };
CustomStack.MinStack minStack = new CustomStack.MinStack(arr);
Util.WriteDebug($"The min value in [{string.Join(",", arr)}]: {minStack.GetMinValue()}");

CustomStack.BalancedExpr expression = new();
string expr = "(){]";
Util.WriteDebug($"Expected: 40 Popped Element: {expression.IsBalancedExpr(expr)}");
expr = "{[()]}";
Util.WriteDebug($"Expected: 40 Popped Element: {expression.IsBalancedExpr(expr)}");

CustomStack.Stack<int> stack = new(5);
stack.Push(10);
stack.Push(20);
stack.Push(30);
stack.Push(40);

Util.WriteDebug($"Expected: 40 Popped Element: {stack.Pop()}");
Util.WriteDebug($"Expected: 30 Peak Element: {stack.Peak()}");
Util.WriteDebug($"Expected: 30 Popped Element: {stack.Pop()}");
Util.WriteDebug($"Expected: 20 Peak Element: {stack.Peak()}");
Util.WriteDebug($"Expected: false IsEmpty: {stack.IsEmpty()}");