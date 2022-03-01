﻿using System;

namespace behaviac
{
	// Token: 0x02002CB9 RID: 11449
	public static class bt_Monster_AI_65Tuanben_65TB_Tanglang_Event
	{
		// Token: 0x06014267 RID: 82535 RVA: 0x0060D148 File Offset: 0x0060B548
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/65Tuanben/65TB_Tanglang_Event");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7 parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node = new Parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7();
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetId(7);
			bt.AddChild(parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.AddChild(sequence);
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node1 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node1();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetId(1);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.SetId(2);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.SetId(4);
			sequence.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetId(12);
			sequence.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node24 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node24();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.SetId(24);
			sequence.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node2.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.SetId(6);
			sequence.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node3.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(8);
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.AddChild(sequence2);
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.SetId(9);
			sequence2.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node28 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node28();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.SetId(28);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node4.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.SetId(10);
			sequence2.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.SetId(11);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.SetId(13);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node6.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node25 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node25();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.SetId(25);
			sequence2.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(22);
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.AddChild(sequence3);
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node23 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node23();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.SetId(23);
			sequence3.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node7.HasEvents());
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node18 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node18();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.SetId(18);
			sequence3.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node19 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node19();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.SetId(19);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node8.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node5();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.SetId(5);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node27 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node27();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10.SetId(27);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node10.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node20 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node20();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11.SetId(20);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node11.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node29 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node29();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12.SetId(29);
			sequence3.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node12.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(14);
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.AddChild(sequence4);
			Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node15 condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9 = new Condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node15();
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.SetId(15);
			sequence4.AddChild(condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node9.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node16 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node16();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13.SetId(16);
			sequence4.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node13.HasEvents());
			Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node17 action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node14 = new Action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node17();
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node14.SetClassNameString("Action");
			action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node14.SetId(17);
			sequence4.AddChild(action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node14);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node14.HasEvents());
			parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.SetHasEvents(parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents() | sequence4.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_65Tuanben_65TB_Tanglang_Event_node.HasEvents());
			return true;
		}
	}
}
