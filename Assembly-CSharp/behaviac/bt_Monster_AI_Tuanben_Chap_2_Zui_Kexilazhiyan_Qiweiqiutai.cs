﻿using System;

namespace behaviac
{
	// Token: 0x020037CF RID: 14287
	public static class bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai
	{
		// Token: 0x0601579C RID: 87964 RVA: 0x0067B4CC File Offset: 0x006798CC
		public static bool build_behavior_tree(BehaviorTree bt)
		{
			bt.SetClassNameString("BehaviorTree");
			bt.SetId(-1);
			bt.SetName("Monster_AI/Tuanben/Chap_2_Zui_Kexilazhiyan_Qiweiqiutai");
			bt.IsFSM = false;
			Parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4 parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node = new Parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4();
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetClassNameString("Parallel");
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetId(4);
			bt.AddChild(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node);
			Sequence sequence = new Sequence();
			sequence.SetClassNameString("Sequence");
			sequence.SetId(1);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.AddChild(sequence);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node0 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node0();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetId(0);
			sequence.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node);
			sequence.SetHasEvents(sequence.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2 action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetId(2);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3 action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.SetId(3);
			sequence.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2);
			sequence.SetHasEvents(sequence.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.HasEvents() | sequence.HasEvents());
			Sequence sequence2 = new Sequence();
			sequence2.SetClassNameString("Sequence");
			sequence2.SetId(5);
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.AddChild(sequence2);
			Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node6 condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2 = new Condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node6();
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.SetClassNameString("Condition");
			condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.SetId(6);
			sequence2.AddChild(condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2);
			sequence2.SetHasEvents(sequence2.HasEvents() | condition_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node2.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node7 action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node7();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3.SetId(7);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node3.HasEvents());
			Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node8 action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4 = new Action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node8();
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4.SetClassNameString("Action");
			action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4.SetId(8);
			sequence2.AddChild(action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4);
			sequence2.SetHasEvents(sequence2.HasEvents() | action_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node4.HasEvents());
			parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.SetHasEvents(parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.HasEvents() | sequence2.HasEvents());
			bt.SetHasEvents(bt.HasEvents() | parallel_bt_Monster_AI_Tuanben_Chap_2_Zui_Kexilazhiyan_Qiweiqiutai_node.HasEvents());
			return true;
		}
	}
}
