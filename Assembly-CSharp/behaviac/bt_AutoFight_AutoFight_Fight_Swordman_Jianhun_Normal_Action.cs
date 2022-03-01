﻿using System;

namespace behaviac
{
	// Token: 0x02002302 RID: 8962
	public static class bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action
	{
		// Token: 0x06012F7D RID: 77693 RVA: 0x0059B508 File Offset: 0x00599908
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("AutoFight/AutoFight_Fight_Swordman_Jianhun_Normal_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(1);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(30);
			selector.AddChild(sequence);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node52 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node52();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.SetId(52);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node51 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node51();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.SetId(51);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node59 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node59();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.SetId(59);
			sequence.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node60 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node60();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.SetId(60);
			sequence.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(95);
			selector.AddChild(sequence2);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node97 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node97();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.SetId(97);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node27 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node27();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.SetId(27);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node99 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node99();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.SetId(99);
			sequence2.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node28 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node28();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.SetId(28);
			sequence2.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(2);
			selector.AddChild(sequence3);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node7 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node7.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node7.SetId(3);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node7.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node8 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node8.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node8.SetId(4);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node8.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9.SetId(5);
			sequence3.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.SetId(6);
			sequence3.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(8);
			selector.AddChild(sequence4);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10.SetId(11);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node9();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11.SetId(9);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node11.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node10();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12.SetId(10);
			sequence4.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node0 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node0();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.SetId(0);
			sequence4.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node4.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(42);
			selector.AddChild(sequence5);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node44 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node44();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13.SetId(44);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node31 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node31();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14.SetId(31);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node45 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node45();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15.SetId(45);
			sequence5.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node46 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node46();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.SetId(46);
			sequence5.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node5.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(7);
			selector.AddChild(sequence6);
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node16 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node12();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node16.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node16.SetId(12);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node16);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node16.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node17 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node13();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node17.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node17.SetId(13);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node17);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node17.HasEvents());
			Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14 condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node18 = new Condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node14();
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node18.SetClassNameString("Condition");
			condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node18.SetId(14);
			sequence6.AddChild(condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node18);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node18.HasEvents());
			Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15 action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6 = new Action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node15();
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.SetClassNameString("Action");
			action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.SetId(15);
			sequence6.AddChild(action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_AutoFight_AutoFight_Fight_Swordman_Jianhun_Normal_Action_node6.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence6.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}