﻿using System;

namespace behaviac
{
	// Token: 0x02003F08 RID: 16136
	public static class bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event
	{
		// Token: 0x06016585 RID: 91525 RVA: 0x006C294C File Offset: 0x006C0D4C
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Zhanguo/Moster_zhitianxinchang_Event");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node1 condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node = new Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node1();
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetId(1);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2 condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2 = new Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2();
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2.SetId(2);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node2.HasEvents());
			Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node4 condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3 = new Condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node4();
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3.SetClassNameString("Condition");
			condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3.SetId(4);
			sequence.AddChild(condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3.HasEvents());
			Action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3 action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node = new Action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node3();
			action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetClassNameString("Action");
			action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetId(3);
			sequence.AddChild(action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.HasEvents());
			Assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node5 assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node = new Assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node5();
			assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.SetId(5);
			sequence.AddChild(assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_Zhanguo_Moster_zhitianxinchang_Event_node.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
