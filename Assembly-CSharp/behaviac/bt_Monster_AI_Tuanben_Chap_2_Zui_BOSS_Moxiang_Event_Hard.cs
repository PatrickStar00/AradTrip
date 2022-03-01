﻿using System;

namespace behaviac
{
	// Token: 0x020037B6 RID: 14262
	public static class bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard
	{
		// Token: 0x0601576F RID: 87919 RVA: 0x0067A2EC File Offset: 0x006786EC
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Tuanben/Chap_2_Zui_BOSS_Moxiang_Event_Hard");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5 parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node = new Parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5();
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetId(5);
			bt.AddChild(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetId(2);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node1 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node1();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetId(1);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.SetId(3);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.SetId(4);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node2.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(6);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence2);
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.SetId(10);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.SetId(7);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node3.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.SetId(8);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node21 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node21();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.SetId(21);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.SetId(11);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node4.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence2.HasEvents());
			Sequence sequence3 = new Sequence();
			sequence3.SetClassNameString("Sequence");
			sequence3.SetId(9);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence3);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node13 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node13();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.SetId(13);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node14 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node14();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.SetId(14);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.HasEvents());
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node19 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node19();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.SetId(19);
			sequence3.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8);
			sequence3.SetHasEvents(sequence3.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node12 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node12();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.SetId(12);
			sequence3.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5);
			sequence3.SetHasEvents(sequence3.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node5.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence3.HasEvents());
			Sequence sequence4 = new Sequence();
			sequence4.SetClassNameString("Sequence");
			sequence4.SetId(20);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence4);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node27 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node27();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.SetId(27);
			sequence4.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9);
			sequence4.SetHasEvents(sequence4.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node26 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node26();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.SetId(26);
			sequence4.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6);
			sequence4.SetHasEvents(sequence4.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node6.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence4.HasEvents());
			Sequence sequence5 = new Sequence();
			sequence5.SetClassNameString("Sequence");
			sequence5.SetId(28);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence5);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node29 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node29();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10.SetId(29);
			sequence5.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10);
			sequence5.SetHasEvents(sequence5.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node10.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node30 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node30();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.SetId(30);
			sequence5.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7);
			sequence5.SetHasEvents(sequence5.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node7.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence5.HasEvents());
			Sequence sequence6 = new Sequence();
			sequence6.SetClassNameString("Sequence");
			sequence6.SetId(15);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.AddChild(sequence6);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node16 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node16();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11.SetId(16);
			sequence6.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11);
			sequence6.SetHasEvents(sequence6.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node11.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node17 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node17();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.SetId(17);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node8.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node18 action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node18();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.SetId(18);
			sequence6.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9);
			sequence6.SetHasEvents(sequence6.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node9.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents() | sequence6.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_BOSS_Moxiang_Event_Hard_node.HasEvents());
			return true;
		}
	}
}
