﻿using System;

namespace behaviac
{
	// Token: 0x020033C2 RID: 13250
	public static class bt_Monster_AI_GWGC_GWGC_qishiyuanjun
	{
		// Token: 0x06014FDC RID: 85980 RVA: 0x006532A4 File Offset: 0x006516A4
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/GWGC/GWGC_qishiyuanjun");
			bt.IsFSM = false;
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(0);
			bt.AddChild(sequence);
			Condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node1 condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node = new Condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node1();
			condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetId(1);
			sequence.AddChild(condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.HasEvents());
			Condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node5 condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node2 = new Condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node5();
			condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node2.SetId(5);
			sequence.AddChild(condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node2);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node2.HasEvents());
			Action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node3 action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node = new Action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node3();
			action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetClassNameString("Action");
			action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetId(3);
			sequence.AddChild(action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.HasEvents());
			Assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node4 assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node = new Assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node4();
			assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetClassNameString("Assignment");
			assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.SetId(4);
			sequence.AddChild(assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node);
			sequence.SetHasEvents(sequence.HasEvents() | assignment_bt_Monster_AI_GWGC_GWGC_qishiyuanjun_node.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | sequence.HasEvents());
			return true;
		}
	}
}
