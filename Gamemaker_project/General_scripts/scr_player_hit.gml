if ((oPlayer.just_hit == 0) && (oPlayer.isDead == 0))
{
    oPlayer.just_hit = 1;
    oPlayer.hitPoints -= 1;
    scr_player_knockback();
    audio_play_sound(sdHit,0,0);
    if (oPlayer.hitPoints == 0)
    {
        scr_death();
    }
}