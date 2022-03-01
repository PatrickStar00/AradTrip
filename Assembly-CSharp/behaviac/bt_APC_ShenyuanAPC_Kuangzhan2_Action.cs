﻿using System;

namespace behaviac
{
	// Token: 0x02001E72 RID: 7794
	public static class bt_APC_ShenyuanAPC_Kuangzhan2_Action
	{
		// Token: 0x06012690 RID: 75408 RVA: 0x00561CD0 File Offset: 0x005600D0
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("APC/ShenyuanAPC_Kuangzhan2_Action");
			bt.IsFSM = false;
			Selector selector = new Selector();
			selector.SetClassNameString("Selector");
			selector.SetId(0);
			bt.AddChild(selector);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(47);
			selector.AddChild(sequence);
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node49 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node49();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.SetId(49);
			sequence.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node48 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node48();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.SetId(48);
			sequence.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node52 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node52();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.SetId(52);
			sequence.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node50 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node50();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.SetId(50);
			sequence.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.HasEvents());
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node21 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node21();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.SetId(21);
			sequence.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(4);
			selector.AddChild(sequence2);
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.SetId(5);
			sequence2.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.SetId(6);
			sequence2.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.HasEvents());
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.SetId(7);
			sequence2.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(36);
			selector.AddChild(sequence3);
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node38 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node38();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.SetId(38);
			sequence3.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node37 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node8 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node37();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node8.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node8.SetId(37);
			sequence3.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node8.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node40 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node9 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node40();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node9.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node9.SetId(40);
			sequence3.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node9);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node9.HasEvents());
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node41 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node41();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.SetId(41);
			sequence3.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(69);
			selector.AddChild(sequence4);
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node30 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node30();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.SetId(30);
			sequence4.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node4.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node73 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node10 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node73();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node10.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node10.SetId(73);
			sequence4.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node10);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node10.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node74 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node11 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node74();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node11.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node11.SetId(74);
			sequence4.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node11);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node11.HasEvents());
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node75 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node75();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.SetId(75);
			sequence4.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node5.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(1);
			selector.AddChild(sequence5);
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node18 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node18();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.SetId(18);
			sequence5.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node6.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node12 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node2();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node12.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node12.SetId(2);
			sequence5.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node12);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node12.HasEvents());
			Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3 condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node13 = new Condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node3();
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node13.SetClassNameString("Condition");
			condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node13.SetId(3);
			sequence5.AddChild(condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node13);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node13.HasEvents());
			Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node51 action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7 = new Action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node51();
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.SetClassNameString("Action");
			action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.SetId(51);
			sequence5.AddChild(action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_APC_ShenyuanAPC_Kuangzhan2_Action_node7.HasEvents());
			selector.SetHasEvents(selector.HasEvents() | sequence5.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | selector.HasEvents());
			return true;
		}
	}
}