<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Company extends Model
{
    protected $fillable = [
        'user_id',
        'company_name',
        'company_phone',
        'company_address'
    ];

    public function user(){
        return $this->belongsTo('App\User');
    }

    public function incoming(){
        return $this->hasMany('App\Incoming');
    }

    public function outcoming(){
        return $this->hasMany('App\Outgoing');
    }
}
