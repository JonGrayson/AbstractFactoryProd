using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPosition { }
public class OutsideHitter : IPosition { }
public class OppositeHitter : IPosition { }
public class Setter : IPosition { }
public class MiddleBlocker : IPosition { }
public class Libero : IPosition { }
public class Ace : IPosition { }
public class PinchServer : IPosition { }
public class Defender : IPosition { }
