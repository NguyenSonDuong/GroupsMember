using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupsMember
{
    public class MemberNew
    {
        public Data data { get; set; }
    }

    public class Data
    {
        public Node node { get; set; }
    }

    public class Node
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public New_Members new_members { get; set; }
    }

    public class New_Members
    {
        public Edge[] edges { get; set; }
        public Page_Info page_info { get; set; }
    }

    public class Page_Info
    {
        public bool has_next_page { get; set; }
        public string end_cursor { get; set; }
    }

    public class Edge
    {
        public object invite_status_text { get; set; }
        public Join_Status_Text join_status_text { get; set; }
        public Node1 node { get; set; }
        public string cursor { get; set; }
    }

    public class Join_Status_Text
    {
        public object[] delight_ranges { get; set; }
        public object[] image_ranges { get; set; }
        public object[] inline_style_ranges { get; set; }
        public object[] aggregated_ranges { get; set; }
        public object[] ranges { get; set; }
        public object[] color_ranges { get; set; }
        public string text { get; set; }
    }

    public class Node1
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string __isProfile { get; set; }
        public string name { get; set; }
        public bool is_verified { get; set; }
        public string __isEntity { get; set; }
        public object work_foreign_entity_info { get; set; }
        public string url { get; set; }
        public string __isGroupMember { get; set; }
        public Group_Membership group_membership { get; set; }
        public Profile_Picture profile_picture { get; set; }
        public Bio_Text bio_text { get; set; }
        public User_Type_Renderer user_type_renderer { get; set; }
    }

    public class Group_Membership
    {
        public bool has_member_feed { get; set; }
        public Associated_Group associated_group { get; set; }
        public string id { get; set; }
        public User_Signals_Info user_signals_info { get; set; }
        public Member_Actions[] member_actions { get; set; }
        public Action_Types[] action_types { get; set; }
    }

    public class Associated_Group
    {
        public string id { get; set; }
        public Leaders_Engagement_Logging_Settings leaders_engagement_logging_settings { get; set; }
    }

    public class Leaders_Engagement_Logging_Settings
    {
        public Comet_Surface_Mappings[] comet_surface_mappings { get; set; }
    }

    public class Comet_Surface_Mappings
    {
        public string __typename { get; set; }
        public string surface { get; set; }
        public string trace_policy { get; set; }
        public string[] prefixes { get; set; }
    }

    public class User_Signals_Info
    {
        public Displayed_User_Signals[] displayed_user_signals { get; set; }
        public bool has_more { get; set; }
        public object overflow_uri { get; set; }
        public int total_count { get; set; }
    }

    public class Displayed_User_Signals
    {
        public string id { get; set; }
        public string signal_type_id { get; set; }
        public Lightmodeimage lightModeImage { get; set; }
        public Darkmodeimage darkModeImage { get; set; }
        public Tag_Render_Info tag_render_info { get; set; }
        public Title title { get; set; }
    }

    public class Lightmodeimage
    {
        public string uri { get; set; }
    }

    public class Darkmodeimage
    {
        public string uri { get; set; }
    }

    public class Tag_Render_Info
    {
        public string color_variant { get; set; }
        public string layout_type { get; set; }
    }

    public class Title
    {
        public string text { get; set; }
    }

    public class Member_Actions
    {
        public string __typename { get; set; }
    }

    public class Action_Types
    {
        public string __typename { get; set; }
        public string action_type { get; set; }
    }

    public class Profile_Picture
    {
        public string uri { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int scale { get; set; }
    }

    public class Bio_Text
    {
        public object[] delight_ranges { get; set; }
        public object[] image_ranges { get; set; }
        public object[] inline_style_ranges { get; set; }
        public object[] aggregated_ranges { get; set; }
        public object[] ranges { get; set; }
        public object[] color_ranges { get; set; }
        public string text { get; set; }
    }

    public class User_Type_Renderer
    {
        public string __typename { get; set; }
        public User user { get; set; }
        public __Module_Operation_Groupscometmemberspagememberrowdefaultprofileaddon_Profile __module_operation_GroupsCometMembersPageMemberRowDefaultProfileAddOn_profile { get; set; }
        public __Module_Component_Groupscometmemberspagememberrowdefaultprofileaddon_Profile __module_component_GroupsCometMembersPageMemberRowDefaultProfileAddOn_profile { get; set; }
    }

    public class User
    {
        public string __typename { get; set; }
        public string id { get; set; }
        public string friendship_status { get; set; }
    }

    public class __Module_Operation_Groupscometmemberspagememberrowdefaultprofileaddon_Profile
    {
        public string __dr { get; set; }
    }

    public class __Module_Component_Groupscometmemberspagememberrowdefaultprofileaddon_Profile
    {
        public string __dr { get; set; }
    }

}
