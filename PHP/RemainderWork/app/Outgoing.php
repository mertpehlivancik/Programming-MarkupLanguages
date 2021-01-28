<?php

namespace App;

use Illuminate\Database\Eloquent\Model;

class Outgoing extends Model
{
    protected $fillable = [
        'company_id',
        'amount'
    ];

    public function company(){
        return $this->belongsTo('App\Company');
    }
}
